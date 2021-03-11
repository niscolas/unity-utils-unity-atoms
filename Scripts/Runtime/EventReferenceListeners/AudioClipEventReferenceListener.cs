using Plugins.UnityAtomsUtils.EventReferences;
using Plugins.UnityAtomsUtils.Events;
using Plugins.UnityAtomsUtils.UnityEvents;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.EventReferenceListeners
{
    /// <summary>
    /// Event Reference Listener of type `AudioClip`. Inherits from `AtomEventReferenceListener&lt;AudioClip, AudioClipEvent, AudioClipEventReference, AudioClipUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/AudioClip Event Reference Listener")]
    public sealed class AudioClipEventReferenceListener : AtomEventReferenceListener<
        AudioClip,
        AudioClipEvent,
        AudioClipEventReference,
        AudioClipUnityEvent>
    { }
}
