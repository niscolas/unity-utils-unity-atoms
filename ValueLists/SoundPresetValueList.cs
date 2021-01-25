using Plugins.AudioUtils;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `SoundPreset`. Inherits from `AtomValueList&lt;SoundPreset, SoundPresetEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/SoundPreset", fileName = "SoundPresetValueList")]
    public sealed class SoundPresetValueList : AtomValueList<SoundPreset, SoundPresetEvent> { }
}
