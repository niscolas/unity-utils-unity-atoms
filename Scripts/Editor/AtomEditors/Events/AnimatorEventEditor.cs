#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Animator`. Inherits from `AtomEventEditor&lt;Animator, AnimatorEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(AnimatorEvent))]
    public sealed class AnimatorEventEditor : AtomEventEditor<Animator, AnimatorEvent> { }
}
#endif
