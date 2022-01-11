#if UNITY_2019_1_OR_NEWER
using UnityAtoms.Editor;
using UnityEditor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    ///     Variable property drawer of type `UnityEngine.Vector2Int`. Inherits from `AtomDrawer&lt;Vector2IntVariable&gt;`.
    ///     Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Vector2IntVariable))]
    public class Vector2IntVariableDrawer : VariableDrawer<Vector2IntVariable> { }
}
#endif