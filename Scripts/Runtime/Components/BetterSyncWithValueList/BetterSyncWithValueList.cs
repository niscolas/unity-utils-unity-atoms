using System;
using niscolas.UnityUtils.Core;
using UnityAtoms;
using UnityEngine;
using UnityUtils;

namespace niscolas.UnityUtils.UnityAtoms
{
    public abstract class BetterSyncWithValueList<T, E, L> : MonoBehaviour
        where E : AtomEvent<T>
        where L : AtomValueList<T, E>
    {
        [SerializeField]
        private L _valueList;

        [SerializeField]
        private MonoCallbackType _addMoment = MonoCallbackType.OnEnable;

        [SerializeField]
        private MonoCallbackType _removeMoment = MonoCallbackType.OnDisable;

        private T _syncSubject;

        // TODO fix mono lifecycle
        private void Awake()
        {
            _syncSubject = GetSyncSubject();
            // MonoLifeCycle.TriggerOnMoment(gameObject, Add, _addMoment);
            // MonoLifeCycle.TriggerOnMoment(gameObject, Remove, _removeMoment);
        }

        protected abstract T GetSyncSubject();

        private void OnEnable()
        {
            _valueList.Add(_syncSubject);
        }

        private void OnDisable()
        {
            _valueList.Remove(_syncSubject);
        }
    }
}