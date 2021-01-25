using Plugins.AudioUtils;
using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `SoundPreset`. Inherits from `SetVariableValue&lt;SoundPreset, SoundPresetPair, SoundPresetVariable, SoundPresetConstant, SoundPresetReference, SoundPresetEvent, SoundPresetPairEvent, SoundPresetVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/SoundPreset", fileName = "SetSoundPresetVariableValue")]
    public sealed class SetSoundPresetVariableValue : SetVariableValue<
        SoundPreset,
        SoundPresetPair,
        SoundPresetVariable,
        SoundPresetConstant,
        SoundPresetReference,
        SoundPresetEvent,
        SoundPresetPairEvent,
        SoundPresetSoundPresetFunction,
        SoundPresetVariableInstancer>
    { }
}
