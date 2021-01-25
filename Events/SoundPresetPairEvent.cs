using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `SoundPresetPair`. Inherits from `AtomEvent&lt;SoundPresetPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/SoundPresetPair", fileName = "SoundPresetPairEvent")]
    public sealed class SoundPresetPairEvent : AtomEvent<SoundPresetPair>
    {
    }
}
