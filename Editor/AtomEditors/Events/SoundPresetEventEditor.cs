#if UNITY_2019_1_OR_NEWER
using Plugins.AudioUtils;
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SoundPreset`. Inherits from `AtomEventEditor&lt;SoundPreset, SoundPresetEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SoundPresetEvent))]
    public sealed class SoundPresetEventEditor : AtomEventEditor<SoundPreset, SoundPresetEvent> { }
}
#endif
