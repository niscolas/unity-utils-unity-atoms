#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SoundPreset`. Inherits from `AtomDrawer&lt;SoundPresetEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SoundPresetEvent))]
    public class SoundPresetEventDrawer : AtomDrawer<SoundPresetEvent> { }
}
#endif
