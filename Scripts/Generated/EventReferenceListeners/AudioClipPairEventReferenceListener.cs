using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `AudioClipPair`. Inherits from `AtomEventReferenceListener&lt;AudioClipPair, AudioClipPairEvent, AudioClipPairEventReference, AudioClipPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/AudioClipPair Event Reference Listener")]
    public sealed class AudioClipPairEventReferenceListener : AtomEventReferenceListener<
        AudioClipPair,
        AudioClipPairEvent,
        AudioClipPairEventReference,
        AudioClipPairUnityEvent>
    { }
}
