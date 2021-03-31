using UnityEngine;

namespace Plugins.Scripts.Actions.SetAnimatorParam
{
	[CreateAssetMenu(
		menuName = Constants.ActionsCreateAssetMenuPath + "(Animator) => Set Bool")]
	public class SetAnimatorBool : BaseSetAnimatorParam<bool>
	{
		public override void Do(Animator animator)
		{
			animator.SetBool(paramName.Value, value);
		}
	}
}