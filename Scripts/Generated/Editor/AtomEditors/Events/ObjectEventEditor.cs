#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `UnityEngine.Object`. Inherits from `AtomEventEditor&lt;UnityEngine.Object, ObjectEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ObjectEvent))]
    public sealed class ObjectEventEditor : AtomEventEditor<UnityEngine.Object, ObjectEvent> { }
}
#endif
