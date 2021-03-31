#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `AnimatorPair`. Inherits from `AtomDrawer&lt;AnimatorPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AnimatorPairEvent))]
    public class AnimatorPairEventDrawer : AtomDrawer<AnimatorPairEvent> { }
}
#endif
