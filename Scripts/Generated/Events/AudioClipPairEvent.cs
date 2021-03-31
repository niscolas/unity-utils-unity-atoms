using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `AudioClipPair`. Inherits from `AtomEvent&lt;AudioClipPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/AudioClipPair", fileName = "AudioClipPairEvent")]
    public sealed class AudioClipPairEvent : AtomEvent<AudioClipPair>
    {
    }
}
