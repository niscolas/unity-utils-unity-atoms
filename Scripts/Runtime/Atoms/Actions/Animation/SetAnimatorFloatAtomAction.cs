using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.ActionsCreateAssetMenuPrefix + "(Animator) => Set Float",
        order = Constants.CreateAssetMenuOrder)]
    public class SetAnimatorFloatAtomAction : AtomAction<Animator>
    {
        [SerializeField]
        private StringReference _param;

        [SerializeField]
        private IntReference _value;

        public override void Do(Animator animator)
        {
            animator.SetFloat(_param.Value, _value.Value);
        }
    }
}