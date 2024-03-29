#if UNITY_2019_1_OR_NEWER
using UnityAtoms.Editor;
using UnityEditor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    ///     Event property drawer of type `UnityEngine.Object`. Inherits from `AtomDrawer&lt;ObjectEvent&gt;`. Only availble in
    ///     `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ObjectEvent))]
    public class ObjectEventDrawer : AtomDrawer<ObjectEvent> { }
}
#endif