using niscolas.UnityUtils.Core;
using UnityAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    public abstract class BetterSyncWithValueListMB<T, E, L> : CachedMonoBehaviour
        where E : AtomEvent<T>
        where L : AtomValueList<T, E>
    {
        [SerializeField]
        private L _valueList;

        [SerializeField]
        private MonoBehaviourEventType _addMoment = MonoBehaviourEventType.OnEnable;

        [SerializeField]
        private MonoBehaviourEventType _removeMoment = MonoBehaviourEventType.OnDisable;

        public const string NiceClassSuffix = " Better Sync with Value List";

        private T _syncSubject;

        // TODO fix mono lifecycle
        protected override void Awake()
        {
            base.Awake();
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