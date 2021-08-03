using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityEngine.Animator&gt;`. Inherits from `IPair&lt;UnityEngine.Animator&gt;`.
    /// </summary>
    [Serializable]
    public struct AnimatorPair : IPair<UnityEngine.Animator>
    {
        public UnityEngine.Animator Item1 { get => _item1; set => _item1 = value; }
        public UnityEngine.Animator Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private UnityEngine.Animator _item1;
        [SerializeField]
        private UnityEngine.Animator _item2;

        public void Deconstruct(out UnityEngine.Animator item1, out UnityEngine.Animator item2) { item1 = Item1; item2 = Item2; }
    }
}