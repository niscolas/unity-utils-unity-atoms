#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `SoundPreset`. Inherits from `AtomDrawer&lt;SoundPresetVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SoundPresetVariable))]
    public class SoundPresetVariableDrawer : VariableDrawer<SoundPresetVariable> { }
}
#endif
