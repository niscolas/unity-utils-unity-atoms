using System.Linq;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.FunctionsCreateAssetMenuPrefix + "(GameObject) => Select With Tag : GameObject")]
    public class SelectWithTag : GameObjectGameObjectFunction
    {
        [SerializeField]
        private StringConstant tag;

        [SerializeField]
        private bool searchInParents = true;

        [SerializeField]
        private bool searchInChildren = true;

        public override GameObject Call(GameObject entry)
        {
            if (!entry || !tag)
            {
                return default;
            }

            GameObject result;

            result = entry
                .FindWithTagInHierarchy(tag.Value, searchInParents, searchInChildren)
                .FirstOrDefault();

            return result;
        }
    }
}
