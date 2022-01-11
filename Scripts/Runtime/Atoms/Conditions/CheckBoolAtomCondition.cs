using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.ConditionsCreateAssetMenuPrefix + "(bool) => Is True?",
        order = Constants.CreateAssetMenuOrder)]
    public class CheckBoolAtomCondition : BoolCondition
    {
        [SerializeField]
        private bool invert;

        public override bool Call(bool value)
        {
            return invert ? !value : value;
        }
    }
}