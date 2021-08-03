#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `UnityEngine.Animator`. Inherits from `AtomEventEditor&lt;UnityEngine.Animator, AnimatorEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(AnimatorEvent))]
    public sealed class AnimatorEventEditor : AtomEventEditor<UnityEngine.Animator, AnimatorEvent> { }
}
#endif
