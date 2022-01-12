using niscolas.UnityUtils.Core;
using UnityAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    public abstract class BetterSyncWithValueList<T, E, L> : MonoBehaviour
        where E : AtomEvent<T>
        where L : AtomValueList<T, E>
    {
        [SerializeField]
        private L _valueList;

        [SerializeField]
        private MonoBehaviourEventType _addMoment = MonoBehaviourEventType.OnEnable;

        [SerializeField]
        private MonoBehaviourEventType _removeMoment = MonoBehaviourEventType.OnDisable;

        private T _syncSubject;

        // TODO fix mono lifecycle
        private void Awake()
        {
            _syncSubject = GetSyncSubject();
            // MonoLifeCycle.TriggerOnMoment(gameObject, Add, _addMoment);
            // MonoLifeCycle.TriggerOnMoment(gameObject, Remove, _removeMoment);
        }

        private void OnEnable()
        {
            _valueList.Add(_syncSubject);
        }

        private void OnDisable()
        {
            _valueList.Remove(_syncSubject);
        }

        protected abstract T GetSyncSubject();
    }
}