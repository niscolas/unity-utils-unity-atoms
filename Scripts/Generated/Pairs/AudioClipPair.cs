using System;
using UnityEngine;
namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// IPair of type `&lt;UnityEngine.AudioClip&gt;`. Inherits from `IPair&lt;UnityEngine.AudioClip&gt;`.
    /// </summary>
    [Serializable]
    public struct AudioClipPair : IPair<UnityEngine.AudioClip>
    {
        public UnityEngine.AudioClip Item1 { get => _item1; set => _item1 = value; }
        public UnityEngine.AudioClip Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private UnityEngine.AudioClip _item1;
        [SerializeField]
        private UnityEngine.AudioClip _item2;

        public void Deconstruct(out UnityEngine.AudioClip item1, out UnityEngine.AudioClip item2) { item1 = Item1; item2 = Item2; }
    }
}