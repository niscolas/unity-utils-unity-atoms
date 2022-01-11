using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     IPair of type `&lt;UnityEngine.Object&gt;`. Inherits from `IPair&lt;UnityEngine.Object&gt;`.
    /// </summary>
    [Serializable]
    public struct ObjectPair : IPair<Object>
    {
        [SerializeField]
        private Object _item1;

        [SerializeField]
        private Object _item2;

        public Object Item1
        {
            get => _item1;
            set => _item1 = value;
        }

        public Object Item2
        {
            get => _item2;
            set => _item2 = value;
        }

        public void Deconstruct(out Object item1, out Object item2)
        {
            item1 = Item1;
            item2 = Item2;
        }
    }
}