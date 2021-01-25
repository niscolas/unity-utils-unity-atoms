using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Events
{
    /// <summary>
    /// Event of type `AudioClip`. Inherits from `AtomEvent&lt;AudioClip&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/AudioClip", fileName = "AudioClipEvent")]
    public sealed class AudioClipEvent : AtomEvent<AudioClip>
    {
    }
}
