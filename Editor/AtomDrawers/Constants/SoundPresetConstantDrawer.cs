#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `SoundPreset`. Inherits from `AtomDrawer&lt;SoundPresetConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SoundPresetConstant))]
    public class SoundPresetConstantDrawer : VariableDrawer<SoundPresetConstant> { }
}
#endif
