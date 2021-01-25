#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SoundPresetPair`. Inherits from `AtomDrawer&lt;SoundPresetPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SoundPresetPairEvent))]
    public class SoundPresetPairEventDrawer : AtomDrawer<SoundPresetPairEvent> { }
}
#endif
