#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `AnimatorPair`. Inherits from `AtomEventEditor&lt;AnimatorPair, AnimatorPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(AnimatorPairEvent))]
    public sealed class AnimatorPairEventEditor : AtomEventEditor<AnimatorPair, AnimatorPairEvent> { }
}
#endif
