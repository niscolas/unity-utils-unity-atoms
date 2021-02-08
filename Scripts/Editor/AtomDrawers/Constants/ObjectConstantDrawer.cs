#if UNITY_2019_1_OR_NEWER
using Plugins.UnityAtomsUtils.Constants;
using UnityAtoms.Editor;
using UnityEditor;

namespace Plugins.UnityAtomsUtils.Editor.AtomDrawers.Constants
{
    /// <summary>
    /// Constant property drawer of type `Object`. Inherits from `AtomDrawer&lt;ObjectConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ObjectConstant))]
    public class ObjectConstantDrawer : VariableDrawer<ObjectConstant> { }
}
#endif
