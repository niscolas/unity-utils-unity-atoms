using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(menuName = Constants.ActionsCreateAssetMenuPrefix + "(GameObject) => Set Position")]
    public class SetPositionAtom : AtomAction<GameObject>
    {
        [SerializeField]
        private Vector3Variable targetPosition;

        public override void Do(GameObject entryValue)
        {
            entryValue.transform.position = targetPosition.Value;
        }
    }
}