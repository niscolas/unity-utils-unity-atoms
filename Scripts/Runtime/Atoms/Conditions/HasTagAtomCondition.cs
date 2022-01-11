using System.Linq;
using niscolas.UnityUtils.UnityAtoms;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtomsUtils.Conditions
{
    [CreateAssetMenu(
        menuName = Constants.ConditionsCreateAssetMenuPrefix + "(GameObject) => Has Tag?",
        order = Constants.CreateAssetMenuOrder)]
    public class HasTagAtomCondition : AtomCondition<GameObject>
    {
        [FormerlySerializedAs("mustHaveTag")]
        [SerializeField]
        private StringConstant tag;

        [SerializeField]
        private bool searchInParents = true;

        [SerializeField]
        private bool searchInChildren = true;

        public override bool Call(GameObject entry)
        {
            return entry.FindWithTagInHierarchy(tag.Value, searchInParents, searchInChildren).Any();
        }
    }
}