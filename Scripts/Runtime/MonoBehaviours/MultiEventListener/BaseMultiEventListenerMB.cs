using niscolas.UnityUtils.Core;
using niscolas.UnityUtils.Core.Extensions;
using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace niscolas.UnityUtils.UnityAtoms
{
    public abstract class BaseMultiEventListenerMB<T, E, ER> : CachedMB, IAtomListener<T>
        where E : AtomEvent<T>
        where ER : IGetEvent, ISetEvent, new()
    {
        [SerializeField]
        private ER[] _events;

        [SerializeField]
        private bool _replayEventBuffer;

        [SerializeField]
        private UnityEvent<T> _unityEventResponse;

        public const string NiceClassSuffix = " Multi Event Listener";

        private void OnEnable()
        {
            _events.ForEach(
                e => e
                    .GetEvent<E>()
                    .RegisterListener(this, _replayEventBuffer));
        }

        private void OnDisable()
        {
            _events.ForEach(
                e => e
                    .GetEvent<E>()
                    .UnregisterListener(this));
        }

        public void OnEventRaised(T item)
        {
            _unityEventResponse?.Invoke(item);
        }
    }
}