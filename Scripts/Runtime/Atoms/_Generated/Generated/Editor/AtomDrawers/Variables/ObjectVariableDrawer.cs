#if UNITY_2019_1_OR_NEWER
using UnityAtoms.Editor;
using UnityEditor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    ///     Variable property drawer of type `UnityEngine.Object`. Inherits from `AtomDrawer&lt;ObjectVariable&gt;`. Only
    ///     availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ObjectVariable))]
    public class ObjectVariableDrawer : VariableDrawer<ObjectVariable> { }
}
#endif