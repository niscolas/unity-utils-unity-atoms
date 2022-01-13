using niscolas.UnityUtils.Core;
using UnityAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    public abstract class VariableInstancerUpdaterMB<V, P, T, E1, E2, F, TVi> : CachedMB
        where V : AtomVariable<T, P, E1, E2, F>
        where P : struct, IPair<T>
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<P>
        where F : AtomFunction<T, T>
        where TVi : AtomVariableInstancer<V, P, T, E1, E2, F>
    {
        [SerializeField]
        private TVi _instancer;

        public const string NiceClassSuffix = " Variable Instancer Updater";

        private E1 _instancerEvent;

        protected override void Awake()
        {
            base.Awake();

            if (!_instancer)
            {
                _instancer = GetComponent<TVi>();

                if (!_instancer)
                {
                    return;
                }
            }

            _instancerEvent = _instancer.Base.GetOrCreateEvent<E1>();

            if (!_instancerEvent)
            {
                return;
            }

            _instancerEvent.Register(UpdateInstancerVariableCopyValue);
        }

        private void OnDestroy()
        {
            if (!_instancerEvent)
            {
                return;
            }

            _instancerEvent.Unregister(UpdateInstancerVariableCopyValue);
        }

        private void UpdateInstancerVariableCopyValue(T newValue)
        {
            _instancer.Value = newValue;
        }
    }
}