using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `SoundPresetPair`. Inherits from `AtomEventReference&lt;SoundPresetPair, SoundPresetVariable, SoundPresetPairEvent, SoundPresetVariableInstancer, SoundPresetPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SoundPresetPairEventReference : AtomEventReference<
        SoundPresetPair,
        SoundPresetVariable,
        SoundPresetPairEvent,
        SoundPresetVariableInstancer,
        SoundPresetPairEventInstancer>, IGetEvent 
    { }
}
