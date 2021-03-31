#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `UnityEngine.Animator`. Inherits from `AtomDrawer&lt;AnimatorConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AnimatorConstant))]
    public class AnimatorConstantDrawer : VariableDrawer<AnimatorConstant> { }
}
#endif
