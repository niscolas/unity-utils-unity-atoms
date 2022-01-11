using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     Value List of type `UnityEngine.AudioClip`. Inherits from `AtomValueList&lt;UnityEngine.AudioClip, AudioClipEvent
    ///     &gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/AudioClip", fileName = "AudioClipValueList")]
    public sealed class AudioClipValueList : AtomValueList<AudioClip, AudioClipEvent> { }
}