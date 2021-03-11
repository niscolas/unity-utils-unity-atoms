using Plugins.UnityAtomsUtils.Events;
using Plugins.UnityAtomsUtils.Pairs;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.EventInstancers
{
    /// <summary>
    /// Event Instancer of type `AudioClipPair`. Inherits from `AtomEventInstancer&lt;AudioClipPair, AudioClipPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/AudioClipPair Event Instancer")]
    public class AudioClipPairEventInstancer : AtomEventInstancer<AudioClipPair, AudioClipPairEvent> { }
}
