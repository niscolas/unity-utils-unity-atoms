using niscolas.UnityUtils.Core.Extensions;
using niscolas.UnityUtils.UnityAtoms;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = UnityAtoms.Constants.ActionsCreateAssetMenuPrefix + "(GameObject) => Set Colliders Is Trigger")]
    public class SetCollidersIsTriggerAtomAction : AtomAction<GameObject>
    {
        [SerializeField]
        private BoolReference _isTrigger;

        public override void Do(GameObject gameObject)
        {
            Collider[] colliders = gameObject.GetComponents<Collider>();
            if (colliders.IsNullOrEmpty())
            {
                return;
            }

            colliders.ForEach(c => c.isTrigger = _isTrigger.Value);
        }
    }
}