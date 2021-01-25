using System;
using Plugins.AudioUtils;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `SoundPreset`. Inherits from `AtomReference&lt;SoundPreset, SoundPresetPair, SoundPresetConstant, SoundPresetVariable, SoundPresetEvent, SoundPresetPairEvent, SoundPresetSoundPresetFunction, SoundPresetVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SoundPresetReference : AtomReference<
        SoundPreset,
        SoundPresetPair,
        SoundPresetConstant,
        SoundPresetVariable,
        SoundPresetEvent,
        SoundPresetPairEvent,
        SoundPresetSoundPresetFunction,
        SoundPresetVariableInstancer>, IEquatable<SoundPresetReference>
    {
        public SoundPresetReference() : base() { }
        public SoundPresetReference(SoundPreset value) : base(value) { }
        public bool Equals(SoundPresetReference other) { return base.Equals(other); }
        protected override bool ValueEquals(SoundPreset other)
        {
            throw new NotImplementedException();
        }
    }
}
