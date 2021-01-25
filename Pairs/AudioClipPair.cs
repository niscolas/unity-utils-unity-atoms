using System;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Pairs
{
    /// <summary>
    /// IPair of type `&lt;AudioClip&gt;`. Inherits from `IPair&lt;AudioClip&gt;`.
    /// </summary>
    [Serializable]
    public struct AudioClipPair : IPair<AudioClip>
    {
        public AudioClip Item1 { get => _item1; set => _item1 = value; }
        public AudioClip Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private AudioClip _item1;
        [SerializeField]
        private AudioClip _item2;

        public void Deconstruct(out AudioClip item1, out AudioClip item2) { item1 = Item1; item2 = Item2; }
    }
}