#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `UnityEngine.Animator`. Inherits from `AtomDrawer&lt;AnimatorVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AnimatorVariable))]
    public class AnimatorVariableDrawer : VariableDrawer<AnimatorVariable> { }
}
#endif
