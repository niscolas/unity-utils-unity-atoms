using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     Event Reference Listener of type `UnityEngine.AudioClip`. Inherits from `AtomEventReferenceListener&lt;
    ///     UnityEngine.AudioClip, AudioClipEvent, AudioClipEventReference, AudioClipUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/AudioClip Event Reference Listener")]
    public sealed class AudioClipEventReferenceListener : AtomEventReferenceListener<
        AudioClip,
        AudioClipEvent,
        AudioClipEventReference,
        AudioClipUnityEvent> { }
}