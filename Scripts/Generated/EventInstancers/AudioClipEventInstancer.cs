using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `UnityEngine.AudioClip`. Inherits from `AtomEventInstancer&lt;UnityEngine.AudioClip, AudioClipEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/AudioClip Event Instancer")]
    public class AudioClipEventInstancer : AtomEventInstancer<UnityEngine.AudioClip, AudioClipEvent> { }
}
