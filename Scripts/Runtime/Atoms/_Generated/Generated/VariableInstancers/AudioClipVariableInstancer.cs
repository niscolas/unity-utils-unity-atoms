using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `UnityEngine.AudioClip`. Inherits from `AtomVariableInstancer&lt;AudioClipVariable, AudioClipPair, UnityEngine.AudioClip, AudioClipEvent, AudioClipPairEvent, AudioClipAudioClipFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/AudioClip Variable Instancer")]
    public class AudioClipVariableInstancer : AtomVariableInstancer<
        AudioClipVariable,
        AudioClipPair,
        UnityEngine.AudioClip,
        AudioClipEvent,
        AudioClipPairEvent,
        AudioClipAudioClipFunction>
    { }
}
