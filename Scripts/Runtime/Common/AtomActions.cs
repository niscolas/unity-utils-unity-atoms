using System;
using System.Collections;
using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [Serializable]
    public struct BaseAtomActions : IEnumerable<AtomAction>
    {
        [SerializeField]
        private List<AtomAction> _content;

        public IEnumerator<AtomAction> GetEnumerator()
        {
            return _content.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Do()
        {
            _content.ForEach(a => a.Do());
        }
    }

    [Serializable]
    public struct AtomActions<T> : IEnumerable<AtomAction<T>>
    {
        [SerializeField]
        private List<AtomAction<T>> _content;

        public IEnumerator<AtomAction<T>> GetEnumerator()
        {
            return _content.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Do(T value)
        {
            _content.ForEach(a => a.Do(value));
        }

        public void Do()
        {
            _content.ForEach(a => a.Do());
        }
    }
}