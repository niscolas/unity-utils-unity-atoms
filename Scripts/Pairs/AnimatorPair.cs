using System;
using UnityEngine;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;Animator&gt;`. Inherits from `IPair&lt;Animator&gt;`.
    /// </summary>
    [Serializable]
    public struct AnimatorPair : IPair<Animator>
    {
        public Animator Item1 { get => _item1; set => _item1 = value; }
        public Animator Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Animator _item1;
        [SerializeField]
        private Animator _item2;

        public void Deconstruct(out Animator item1, out Animator item2) { item1 = Item1; item2 = Item2; }
    }
}