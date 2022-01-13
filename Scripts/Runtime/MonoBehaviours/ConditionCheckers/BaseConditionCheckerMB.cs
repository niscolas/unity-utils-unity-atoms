using niscolas.UnityUtils.Core;
using Sirenix.OdinInspector;
using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace niscolas.UnityUtils.UnityAtoms
{
    public abstract class BaseConditionCheckerMB<T, P, C, V, E1, E2, F, VI, TR> : CachedMB
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
        private AtomCondition<T> _condition;

        [SerializeField]
        private TR _fixedInput;

        [Title(HeaderTitles.Events)]
        [SerializeField]
        private UnityEvent<T> _onConditionMet;

        [SerializeField]
        private UnityEvent<T> _onConditionFailed;

        public const string NiceClassSuffix = " Condition Checker";

        public void Check(T input)
        {
            if (_condition.Call(input))
            {
                _onConditionMet?.Invoke(input);
            }
            else
            {
                _onConditionFailed?.Invoke(input);
            }
        }

        public void Check()
        {
            T inputValue = default;

            if (_fixedInput != null)
            {
                inputValue = _fixedInput.Value;
            }

            Check(inputValue);
        }
    }
}