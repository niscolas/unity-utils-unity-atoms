using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    public abstract class BaseSetAnimatorParamAtomAction<T> : AtomAction<Animator>
    {
        [SerializeField]
        protected StringReference _paramName;

        [SerializeField]
        protected T _value;
    }
}