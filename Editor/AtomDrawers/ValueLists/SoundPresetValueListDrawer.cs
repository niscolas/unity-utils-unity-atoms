#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `SoundPreset`. Inherits from `AtomDrawer&lt;SoundPresetValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SoundPresetValueList))]
    public class SoundPresetValueListDrawer : AtomDrawer<SoundPresetValueList> { }
}
#endif
