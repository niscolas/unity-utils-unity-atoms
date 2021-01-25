using System;
using Plugins.AudioUtils;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `SoundPreset`. Inherits from `AtomEventReference&lt;SoundPreset, SoundPresetVariable, SoundPresetEvent, SoundPresetVariableInstancer, SoundPresetEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SoundPresetEventReference : AtomEventReference<
        SoundPreset,
        SoundPresetVariable,
        SoundPresetEvent,
        SoundPresetVariableInstancer,
        SoundPresetEventInstancer>, IGetEvent 
    { }
}
