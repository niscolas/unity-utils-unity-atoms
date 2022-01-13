using niscolas.UnityUtils.Core;
using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace niscolas.UnityUtils.UnityAtoms
{
    public abstract class BaseAtomFunctionMB<T1, T2> : CachedMB
    {
        [SerializeField]
        private AtomFunction<T1, T2> _function;

        [SerializeField]
        private UnityEvent<T1> _onFunctionCalled;

        public const string NiceClassSuffix = " Atom Function";

        public void Call(T2 t2)
        {
            _onFunctionCalled?.Invoke(_function.Call(t2));
        }
    }
}