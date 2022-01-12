using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.ConditionsCreateAssetMenuPrefix + "() => Is Editor?",
        order = Constants.CreateAssetMenuOrder)]
    public class IsEditorAtomCondition : VoidAtomCondition
    {
        [SerializeField]
        private bool invert;

        public override bool Call()
        {
            return invert ? !Application.isEditor : Application.isEditor;
        }
    }
}