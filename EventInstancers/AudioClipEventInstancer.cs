using Plugins.UnityAtomsUtils.Events;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.EventInstancers
{
    /// <summary>
    /// Event Instancer of type `AudioClip`. Inherits from `AtomEventInstancer&lt;AudioClip, AudioClipEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/AudioClip Event Instancer")]
    public class AudioClipEventInstancer : AtomEventInstancer<AudioClip, AudioClipEvent> { }
}
