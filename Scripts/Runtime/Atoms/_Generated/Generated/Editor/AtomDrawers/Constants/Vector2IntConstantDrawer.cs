#if UNITY_2019_1_OR_NEWER
using UnityAtoms.Editor;
using UnityEditor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    ///     Constant property drawer of type `UnityEngine.Vector2Int`. Inherits from `AtomDrawer&lt;Vector2IntConstant&gt;`.
    ///     Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Vector2IntConstant))]
    public class Vector2IntConstantDrawer : VariableDrawer<Vector2IntConstant> { }
}
#endif