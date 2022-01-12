using niscolas.UnityUtils.UnityAtoms;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = UnityAtoms.Constants.ActionsCreateAssetMenuPrefix + "(GameObject) => Set Rigidbody Use Gravity")]
    public class SetRigidbodyUseGravityAtomAction : AtomAction<GameObject>
    {
        [SerializeField]
        private BoolReference _useGravity;

        public override void Do(GameObject gameObject)
        {
            if (!gameObject.TryGetComponent(out Rigidbody rigidbody))
            {
                return;
            }

            rigidbody.useGravity = _useGravity.Value;
        }
    }
}