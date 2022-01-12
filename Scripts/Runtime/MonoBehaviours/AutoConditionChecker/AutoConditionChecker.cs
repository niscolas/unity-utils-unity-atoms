using niscolas.UnityUtils.Core;
using UnityEngine;
using UnityEngine.Events;

namespace niscolas.UnityUtils.UnityAtoms
{
    public abstract class AutoConditionChecker<T> : CachedMonoBehaviour
    {
        [SerializeField]
        private MonoBehaviourEventType _conditionCheckMoment = MonoBehaviourEventType.Awake;

        [SerializeField]
        protected AtomConditions<T> _conditions;

        [Header("Events")]
        [SerializeField]
        private UnityEvent _onSuccess;

        [SerializeField]
        private UnityEvent _onFailure;

        protected override void Awake()
        {
            base.Awake();
            MonoHooksManagerMonoBehaviour.AutoTrigger(_gameObject, CheckEnvironment, _conditionCheckMoment);
        }

        protected virtual void CheckEnvironment()
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