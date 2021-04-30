using Sirenix.OdinInspector;
using UnityEngine;

namespace UnityAtomsUtils.MonoBehaviourHelpers.TransformUtils
{
	public class CopyPosition : BaseCopyTransform
	{
		private const string CopiedAxisText = "Copied Axis";
		private const string CopiedAxisGroup = CopiedAxisText + "/";

		[HorizontalGroup(CopiedAxisText)]
		[VerticalGroup(CopiedAxisGroup + "X")]
		[LabelText("X"), LabelWidth(15)]
		[SerializeField]
		protected bool _copyX = true;

		[VerticalGroup(CopiedAxisGroup + "Y")]
		[LabelText("Y"), LabelWidth(15)]
		[SerializeField]
		protected bool _copyY = true;

		[VerticalGroup(CopiedAxisGroup + "Z")]
		[LabelText("Z"), LabelWidth(15)]
		[SerializeField]
		protected bool _copyZ = true;

		protected override void CopyTransform(Transform copyTarget)
		{
			Vector3 copyTargetPosition = copyTarget.position;
			Vector3 currentPosition = transform.position;

			float x = _copyX ? copyTargetPosition.x : currentPosition.x;
			float y = _copyY ? copyTargetPosition.y : currentPosition.y;
			float z = _copyZ ? copyTargetPosition.z : currentPosition.z;

			transform.position = new Vector3(x, y, z);
		}
	}
}