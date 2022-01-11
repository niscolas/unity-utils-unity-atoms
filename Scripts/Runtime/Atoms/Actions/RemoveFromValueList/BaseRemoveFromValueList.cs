using UnityAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    public abstract class BaseRemoveFromValueList<T, E, VL> : AtomAction<T>
        where VL : AtomValueList<T, E>
        where E : AtomEvent<T>
    {
        [SerializeField]
        private VL valueList;

        public override void Do(T element)
        {
            valueList.Remove(element);
        }
    }
}