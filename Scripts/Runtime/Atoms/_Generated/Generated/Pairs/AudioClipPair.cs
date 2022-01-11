using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     IPair of type `&lt;UnityEngine.AudioClip&gt;`. Inherits from `IPair&lt;UnityEngine.AudioClip&gt;`.
    /// </summary>
    [Serializable]
    public struct AudioClipPair : IPair<AudioClip>
    {
        [SerializeField]
        private AudioClip _item1;

        [SerializeField]
        private AudioClip _item2;

        public AudioClip Item1
        {
            get => _item1;
            set => _item1 = value;
        }

        public AudioClip Item2
        {
            get => _item2;
            set => _item2 = value;
        }

        public void Deconstruct(out AudioClip item1, out AudioClip item2)
        {
            item1 = Item1;
            item2 = Item2;
        }
    }
}