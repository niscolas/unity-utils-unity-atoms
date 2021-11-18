#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `UnityEngine.Vector2Int`. Inherits from `AtomEventEditor&lt;UnityEngine.Vector2Int, Vector2IntEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(Vector2IntEvent))]
    public sealed class Vector2IntEventEditor : AtomEventEditor<UnityEngine.Vector2Int, Vector2IntEvent> { }
}
#endif
