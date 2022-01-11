﻿using niscolas.UnityUtils.Core;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    public abstract class BaseSetAtomEventReferenceReplayBufferSize<T, V, E, VI, EI, ER> : CachedMonoBehaviour
        where E : AtomEvent<T>
        where EI : AtomEventInstancer<T, E>
        where V : IGetOrCreateEvent, ISetEvent
        where VI : IGetOrCreateEvent, ISetEvent
        where ER : AtomEventReference<T, V, E, VI, EI>
    {
        [SerializeField]
        private ER _eventReference;

        [SerializeField]
        private IntReference _size = new();

        private void Start()
        {
            E e = _eventReference.GetEvent<E>();
            e.ReplayBufferSize = 0;
        }
    }
}