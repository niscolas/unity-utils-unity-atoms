using Plugins.AudioUtils;
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `SoundPreset`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(SoundPresetVariable))]
    public sealed class SoundPresetVariableEditor : AtomVariableEditor<SoundPreset, SoundPresetPair> { }
}
