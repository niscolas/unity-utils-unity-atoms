using Plugins.AudioUtils;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `SoundPreset`. Inherits from `AtomEvent&lt;SoundPreset&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/SoundPreset", fileName = "SoundPresetEvent")]
    public sealed class SoundPresetEvent : AtomEvent<SoundPreset>
    {
    }
}
