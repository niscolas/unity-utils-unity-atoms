#if UNITY_2019_1_OR_NEWER
using Plugins.UnityAtomsUtils.Variables;
using UnityAtoms.Editor;
using UnityEditor;

namespace Plugins.UnityAtomsUtils.Editor.AtomDrawers.Variables
{
    /// <summary>
    /// Variable property drawer of type `Object`. Inherits from `AtomDrawer&lt;ObjectVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ObjectVariable))]
    public class ObjectVariableDrawer : VariableDrawer<ObjectVariable> { }
}
#endif
