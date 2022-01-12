using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.ActionsCreateAssetMenuPrefix + "(Animator) => Set Int",
        order = Constants.CreateAssetMenuOrder)]
    public class SetAnimatorIntAtomAction : AtomAction<Animator>
    {
        [SerializeField]
        private StringReference _param;

        [SerializeField]
        private IntReference _value;

        public override void Do(Animator animator)
        {
            animator.SetInteger(_param.Value, _value.Value);
        }
    }
}