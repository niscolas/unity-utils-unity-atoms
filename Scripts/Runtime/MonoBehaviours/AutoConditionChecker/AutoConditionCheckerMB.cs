using niscolas.UnityUtils.Core;
using UnityEngine;
using UnityEngine.Events;

namespace niscolas.UnityUtils.UnityAtoms
{
    public abstract class AutoConditionCheckerMB<T> : AutoTriggerMB
    {
        [SerializeField]
        protected AtomConditions<T> _conditions;

        [Header(HeaderTitles.Events)]
        [SerializeField]
        private UnityEvent _onSuccess;

        [SerializeField]
        private UnityEvent _onFailure;

        public const string NiceClassSuffix = " Auto Condition Checker";

        public override void Do()
        {
            if (_conditions.CallAll(default))

            {
                _onSuccess?.Invoke();
            }
            else
            {
                _onFailure?.Invoke();
            }
        }
    }
}