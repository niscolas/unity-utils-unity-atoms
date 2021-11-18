#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Vector2IntPair`. Inherits from `AtomDrawer&lt;Vector2IntPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Vector2IntPairEvent))]
    public class Vector2IntPairEventDrawer : AtomDrawer<Vector2IntPairEvent> { }
}
#endif
