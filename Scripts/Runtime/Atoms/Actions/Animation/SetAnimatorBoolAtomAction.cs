using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.ActionsCreateAssetMenuPrefix + "(Animator) => Set Bool",
        order = Constants.CreateAssetMenuOrder)]
    public class SetAnimatorBoolAtomAction : BaseSetAnimatorParamAtomAction<bool>
    {
        public override void Do(Animator animator)
        {
            animator.SetBool(_paramName.Value, _value);
        }
    }
}