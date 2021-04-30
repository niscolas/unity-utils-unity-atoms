using System.Collections.Generic;
using UnityEngine;
using UnityExtensions;

namespace UnityAtomsUtils.MonoBehaviourHelpers.TransformUtils
{
	public class PositionLimiter : MonoBehaviour
	{
		[SerializeField]
		private BoundsBehaviour _boundsBehaviour;

		private readonly List<LimitPositionTarget> _targets = new List<LimitPositionTarget>();

		private Bounds Bounds => _boundsBehaviour.Bounds;

		private void Update()
		{
			LimitTargetsPosition();
		}

		public void AddTarget(LimitPositionTarget target)
		{
			_targets.AddIfNotContains(target);
		}

		public void RemoveTarget(LimitPositionTarget target)
		{
			_targets.SafeRemove(target);
		}

		private void LimitTargetsPosition()
		{
			_targets.SafeForEach(LimitTargetPosition);
		}

		private void LimitTargetPosition(LimitPositionTarget target)
		{
			Transform targetTransform = target.TargetTransform;
			Vector3 targetPosition = targetTransform.position;

			if (CheckInsideBounds(targetPosition)) return;

			Vector3 closestValidPoint = Bounds.ClosestPoint(targetPosition);
			targetTransform.position = closestValidPoint;
		}

		private bool CheckInsideBounds(Vector3 testPosition)
		{
			bool result = Bounds.Contains(testPosition);
			return result;
		}

		public void UpdateData(BoundsBehaviour boundsBehaviour)
		{
			_boundsBehaviour = boundsBehaviour;
		}
	}
}