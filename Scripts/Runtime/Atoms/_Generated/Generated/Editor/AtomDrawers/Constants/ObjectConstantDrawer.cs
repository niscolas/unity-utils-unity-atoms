#if UNITY_2019_1_OR_NEWER
using UnityAtoms.Editor;
using UnityEditor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    ///     Constant property drawer of type `UnityEngine.Object`. Inherits from `AtomDrawer&lt;ObjectConstant&gt;`. Only
    ///     availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ObjectConstant))]
    public class ObjectConstantDrawer : VariableDrawer<ObjectConstant> { }
}
#endif