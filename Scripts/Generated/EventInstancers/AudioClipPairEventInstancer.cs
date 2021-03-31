using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `AudioClipPair`. Inherits from `AtomEventInstancer&lt;AudioClipPair, AudioClipPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/AudioClipPair Event Instancer")]
    public class AudioClipPairEventInstancer : AtomEventInstancer<AudioClipPair, AudioClipPairEvent> { }
}
