using Plugins.AudioUtils;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `SoundPreset`. Inherits from `AtomEventReferenceListener&lt;SoundPreset, SoundPresetEvent, SoundPresetEventReference, SoundPresetUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/SoundPreset Event Reference Listener")]
    public sealed class SoundPresetEventReferenceListener : AtomEventReferenceListener<
        SoundPreset,
        SoundPresetEvent,
        SoundPresetEventReference,
        SoundPresetUnityEvent>
    { }
}
