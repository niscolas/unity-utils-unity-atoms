using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Actions.Impl.SetAnimatorParam {
	[CreateAssetMenu(
		menuName = AtomsConstants.ActionsCreateAssetMenuPath + "(Animator) => Set Bool")]
	public class SetAnimatorBool : BaseSetAnimatorParam<bool> {
		public override void Do(UnityEngine.Animator animator) {
			animator.SetBool(paramName.Value, value);
		}
	}
}