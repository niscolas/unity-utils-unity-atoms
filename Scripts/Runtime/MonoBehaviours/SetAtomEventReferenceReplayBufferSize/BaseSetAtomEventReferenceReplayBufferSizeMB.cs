using niscolas.UnityUtils.Core;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    public abstract class BaseSetAtomEventReferenceReplayBufferSizeMB<T, V, E, VI, EI, ER> : CachedMB
        where E : AtomEvent<T>
        where EI : AtomEventInstancer<T, E>
        where V : IGetOrCreateEvent, ISetEvent
        where VI : IGetOrCreateEvent, ISetEvent
        where ER : AtomEventReference<T, V, E, VI, EI>
    {
        [SerializeField]
        private ER _eventReference;

        [SerializeField]
        private IntReference _size = new IntReference();

        public const string NiceClassSuffix = "Set Atom Event Reference Replay Buffer Size";

        private void Start()
        {
            E e = _eventReference.GetEvent<E>();
            e.ReplayBufferSize = 0;
        }
    }
}