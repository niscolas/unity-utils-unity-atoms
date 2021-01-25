#if UNITY_2019_1_OR_NEWER
using Plugins.UnityAtomsUtils.Constants;
using UnityAtoms.Editor;
using UnityEditor;

namespace Plugins.UnityAtomsUtils.Editor.AtomDrawers.Constants
{
    /// <summary>
    /// Constant property drawer of type `AudioClip`. Inherits from `AtomDrawer&lt;AudioClipConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AudioClipConstant))]
    public class AudioClipConstantDrawer : VariableDrawer<AudioClipConstant> { }
}
#endif
