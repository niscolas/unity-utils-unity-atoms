#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Animator`. Inherits from `AtomDrawer&lt;AnimatorVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AnimatorVariable))]
    public class AnimatorVariableDrawer : VariableDrawer<AnimatorVariable> { }
}
#endif
