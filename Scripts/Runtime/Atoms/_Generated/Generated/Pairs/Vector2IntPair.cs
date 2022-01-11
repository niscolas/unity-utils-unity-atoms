using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     IPair of type `&lt;UnityEngine.Vector2Int&gt;`. Inherits from `IPair&lt;UnityEngine.Vector2Int&gt;`.
    /// </summary>
    [Serializable]
    public struct Vector2IntPair : IPair<Vector2Int>
    {
        [SerializeField]
        private Vector2Int _item1;

        [SerializeField]
        private Vector2Int _item2;

        public Vector2Int Item1
        {
            get => _item1;
            set => _item1 = value;
        }

        public Vector2Int Item2
        {
            get => _item2;
            set => _item2 = value;
        }

        public void Deconstruct(out Vector2Int item1, out Vector2Int item2)
        {
            item1 = Item1;
            item2 = Item2;
        }
    }
}