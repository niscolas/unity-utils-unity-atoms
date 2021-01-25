using UnityEngine;
using System;
using Plugins.AudioUtils;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `SoundPreset`. Inherits from `AtomVariable&lt;SoundPreset, SoundPresetPair, SoundPresetEvent, SoundPresetPairEvent, SoundPresetSoundPresetFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/SoundPreset", fileName = "SoundPresetVariable")]
    public sealed class SoundPresetVariable : AtomVariable<SoundPreset, SoundPresetPair, SoundPresetEvent, SoundPresetPairEvent, SoundPresetSoundPresetFunction>
    {
        protected override bool ValueEquals(SoundPreset other)
        {
            throw new NotImplementedException();
        }
    }
}
