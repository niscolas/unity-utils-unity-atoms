using Plugins.AudioUtils;
using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `SoundPreset`. Inherits from `AtomVariableInstancer&lt;SoundPresetVariable, SoundPresetPair, SoundPreset, SoundPresetEvent, SoundPresetPairEvent, SoundPresetSoundPresetFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/SoundPreset Variable Instancer")]
    public class SoundPresetVariableInstancer : AtomVariableInstancer<
        SoundPresetVariable,
        SoundPresetPair,
        SoundPreset,
        SoundPresetEvent,
        SoundPresetPairEvent,
        SoundPresetSoundPresetFunction>
    { }
}
