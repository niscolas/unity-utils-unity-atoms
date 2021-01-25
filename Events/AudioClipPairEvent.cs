using Plugins.UnityAtomsUtils.Pairs;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Events
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
