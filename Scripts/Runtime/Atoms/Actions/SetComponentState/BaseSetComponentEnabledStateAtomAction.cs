using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    public abstract class BaseSetComponentEnabledStateAtomAction<T> : AtomAction<GameObject>
        where T : Behaviour
    {
        [SerializeField]
        private BoolReference _targetState;

        public override void Do(GameObject gameObject)
        {
            if (!gameObject.TryGetComponent(out T component))
            {
                return;
            }

            component.enabled = _targetState.Value;
        }
    }
}