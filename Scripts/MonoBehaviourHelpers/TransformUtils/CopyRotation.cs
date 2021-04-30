using UnityEngine;

namespace UnityAtomsUtils.MonoBehaviourHelpers.TransformUtils
{
	public class CopyRotation : BaseCopyTransform
	{
		protected override void CopyTransform(Transform copyTarget)
		{
			transform.rotation = copyTarget.rotation;
		}
	}
}