using System;
using Plugins.AudioUtils;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;SoundPreset&gt;`. Inherits from `IPair&lt;SoundPreset&gt;`.
    /// </summary>
    [Serializable]
    public struct SoundPresetPair : IPair<SoundPreset>
    {
        public SoundPreset Item1 { get => _item1; set => _item1 = value; }
        public SoundPreset Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private SoundPreset _item1;
        [SerializeField]
        private SoundPreset _item2;

        public void Deconstruct(out SoundPreset item1, out SoundPreset item2) { item1 = Item1; item2 = Item2; }
    }
}