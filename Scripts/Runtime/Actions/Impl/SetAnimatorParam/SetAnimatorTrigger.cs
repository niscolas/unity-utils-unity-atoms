using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Actions.Impl.SetAnimatorParam {
	[CreateAssetMenu(
		menuName = AtomsConstants.ActionsCreateAssetMenuPath + "(Animator) => Set Trigger")]
	public class SetAnimatorTrigger : BaseSetAnimatorParam<Void> {
		public override void Do(UnityEngine.Animator animator) {
			animator.SetTrigger(paramName.Value);
		}
	}
}