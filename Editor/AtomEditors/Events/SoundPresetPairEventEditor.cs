#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SoundPresetPair`. Inherits from `AtomEventEditor&lt;SoundPresetPair, SoundPresetPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SoundPresetPairEvent))]
    public sealed class SoundPresetPairEventEditor : AtomEventEditor<SoundPresetPair, SoundPresetPairEvent> { }
}
#endif
