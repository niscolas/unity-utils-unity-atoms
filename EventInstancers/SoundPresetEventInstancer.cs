using Plugins.AudioUtils;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `SoundPreset`. Inherits from `AtomEventInstancer&lt;SoundPreset, SoundPresetEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/SoundPreset Event Instancer")]
    public class SoundPresetEventInstancer : AtomEventInstancer<SoundPreset, SoundPresetEvent> { }
}
