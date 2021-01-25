using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `SoundPresetPair`. Inherits from `AtomEventReferenceListener&lt;SoundPresetPair, SoundPresetPairEvent, SoundPresetPairEventReference, SoundPresetPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/SoundPresetPair Event Reference Listener")]
    public sealed class SoundPresetPairEventReferenceListener : AtomEventReferenceListener<
        SoundPresetPair,
        SoundPresetPairEvent,
        SoundPresetPairEventReference,
        SoundPresetPairUnityEvent>
    { }
}
