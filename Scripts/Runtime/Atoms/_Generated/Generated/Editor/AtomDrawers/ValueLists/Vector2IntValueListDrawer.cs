#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `UnityEngine.Vector2Int`. Inherits from `AtomDrawer&lt;Vector2IntValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(Vector2IntValueList))]
    public class Vector2IntValueListDrawer : AtomDrawer<Vector2IntValueList> { }
}
#endif
