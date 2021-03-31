using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityEngine.Object&gt;`. Inherits from `IPair&lt;UnityEngine.Object&gt;`.
    /// </summary>
    [Serializable]
    public struct ObjectPair : IPair<UnityEngine.Object>
    {
        public UnityEngine.Object Item1 { get => _item1; set => _item1 = value; }
        public UnityEngine.Object Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private UnityEngine.Object _item1;
        [SerializeField]
        private UnityEngine.Object _item2;

        public void Deconstruct(out UnityEngine.Object item1, out UnityEngine.Object item2) { item1 = Item1; item2 = Item2; }
    }
}