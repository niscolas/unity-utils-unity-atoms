using UnityAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    public abstract class BaseRemoveFromValueListAtomAction<T, E, VL> : AtomAction<T>
        where VL : AtomValueList<T, E>
        where E : AtomEvent<T>
    {
        [SerializeField]
        private VL _valueList;

        public override void Do(T element)
        {
            _valueList.Remove(element);
        }
    }
}