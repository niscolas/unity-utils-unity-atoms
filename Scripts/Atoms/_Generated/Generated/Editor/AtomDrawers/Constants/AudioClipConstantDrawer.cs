#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `UnityEngine.AudioClip`. Inherits from `AtomDrawer&lt;AudioClipConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AudioClipConstant))]
    public class AudioClipConstantDrawer : VariableDrawer<AudioClipConstant> { }
}
#endif
