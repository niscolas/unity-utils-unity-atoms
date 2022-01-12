using niscolas.UnityUtils.Core;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(menuName =
        UnityAtoms.Constants.ConditionsCreateAssetMenuPrefix + "() => Is Current " + nameof(EnvironmentType) + "?")]
    public class IsCurrentEnvironmentTypeAtomAtomCondition : VoidAtomCondition
    {
        [SerializeField]
        private EnvironmentType _testGameEnvironment;

        public override bool Call()
        {
            return _testGameEnvironment.IsCurrentEnvironment();
        }
    }
}