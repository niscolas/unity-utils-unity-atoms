using Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers;
using UnityEngine;

namespace UnityAtomsUtils.MonoBehaviourHelpers.TransformUtils
{
	public abstract class BaseCopyTransform : MonoBehaviour
	{
		[SerializeField]
		private ReferenceOrTag<Transform> _copyTarget;

		private void FixedUpdate()
		{
			Transform copyTargetValue = _copyTarget.Value;
			if (!copyTargetValue) return;

			CopyTransform(copyTargetValue);
		}

		protected abstract void CopyTransform(Transform copyTarget);
	}
}