using niscolas.UnityUtils.UnityAtoms;
using Sirenix.OdinInspector;
using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace niscolas.UnityUtils.Extras
{
    public abstract class ActionGroupAtomAction<T, P, C, V, E1, E2, F, VI, TR> : AtomAction<T>
        where TR : AtomReference<T, P, C, V, E1, E2, F, VI>
        where P : struct, IPair<T>
        where C : AtomBaseVariable<T>
        where V : AtomVariable<T, P, E1, E2, F>
        where E1 : AtomEvent<T>
        where E2 : AtomEvent<P>
        where F : AtomFunction<T, T>
        where VI : AtomVariableInstancer<V, P, T, E1, E2, F>
    {
        [SerializeField]
        private TR _staticValue;

        [SerializeField]
        private UnityEvent<T> _onBeforeActions;

        [SerializeField]
        private BaseAtomActions _baseActions;

        [SerializeField]
        private AtomActions<T> _typedActions;

        [SerializeField]
        private UnityEvent<T> _onAfterActions;

        [Button]
        public override void Do()
        {
            _onBeforeActions?.Invoke(_staticValue.Value);
            _baseActions.Do();
            _typedActions.Do(_staticValue.Value);
            _onAfterActions?.Invoke(_staticValue.Value);
        }

        public override void Do(T value)
        {
            _onBeforeActions?.Invoke(value);
            _baseActions.Do();
            _typedActions.Do(value);
            _onAfterActions?.Invoke(value);
        }
    }
}