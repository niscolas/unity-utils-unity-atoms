using Plugins.UnityAtomsUtils.Events;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.ValueLists
{
    /// <summary>
    /// Value List of type `AudioClip`. Inherits from `AtomValueList&lt;AudioClip, AudioClipEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/AudioClip", fileName = "AudioClipValueList")]
    public sealed class AudioClipValueList : AtomValueList<AudioClip, AudioClipEvent> { }
}
