#if UNITY_2019_1_OR_NEWER
using UnityAtoms.Editor;
using UnityEditor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    ///     Event property drawer of type `Vector2IntPair`. Inherits from `AtomEventEditor&lt;Vector2IntPair,
    ///     Vector2IntPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(Vector2IntPairEvent))]
    public sealed class Vector2IntPairEventEditor : AtomEventEditor<Vector2IntPair, Vector2IntPairEvent> { }
}
#endif