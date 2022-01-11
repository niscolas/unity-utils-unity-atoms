using UnityAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    public abstract class BaseChainFunction<T> : AtomFunction<T, T>
    {
        [SerializeField]
        private AtomFunction<T, T>[] chainedFunctions;

        public sealed override T Call(T entry)
        {
            T result = entry;

            foreach (AtomFunction<T, T> chainedFunction in chainedFunctions)
            {
                result = chainedFunction.Call(result);
            }

            return result;
        }
    }
}