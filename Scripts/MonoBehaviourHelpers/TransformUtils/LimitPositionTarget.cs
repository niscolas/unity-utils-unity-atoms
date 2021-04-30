using Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers;
using UnityEngine;

namespace UnityAtomsUtils.MonoBehaviourHelpers.TransformUtils
{
	public class LimitPositionTarget : MonoBehaviour
	{
		[SerializeField]
		private Transform _targetTransform;

		[SerializeField]
		private ReferenceOrTag<PositionLimiter> _limiter;

		public Transform TargetTransform => _targetTransform;

		public PositionLimiter Limiter
		{
			get => _limiter.Value;
			set => _limiter.Value = value;
		}

		private void Awake()
		{
			UpdateTargetTransform();
		}

		private void Start()
		{
			SubscribeToLimiter();
		}

		private void OnDestroy()
		{
			if (!_limiter.Value) return;

			_limiter.Value.RemoveTarget(this);
		}

		private void UpdateTargetTransform()
		{
			if (!_targetTransform)
			{
				_targetTransform = transform;
			}
		}

		private void SubscribeToLimiter()
		{
			if (!_limiter.Value) return;

			_limiter.Value.AddTarget(this);
		}
	}
}