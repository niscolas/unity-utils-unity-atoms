using UnityAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.ActionsCreateAssetMenuPrefix + "(Animator) => Set Trigger",
        order = Constants.CreateAssetMenuOrder)]
    public class SetAnimatorTriggerAtomAction : BaseSetAnimatorParamAtomAction<Void>
    {
        public override void Do(Animator animator)
        {
            animator.SetTrigger(_paramName.Value);
        }
    }
}