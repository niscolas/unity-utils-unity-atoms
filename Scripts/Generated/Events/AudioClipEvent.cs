using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `UnityEngine.AudioClip`. Inherits from `AtomEvent&lt;UnityEngine.AudioClip&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/AudioClip", fileName = "AudioClipEvent")]
    public sealed class AudioClipEvent : AtomEvent<UnityEngine.AudioClip>
    {
    }
}
