#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `UnityEngine.Animator`. Inherits from `AtomDrawer&lt;AnimatorValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AnimatorValueList))]
    public class AnimatorValueListDrawer : AtomDrawer<AnimatorValueList> { }
}
#endif
