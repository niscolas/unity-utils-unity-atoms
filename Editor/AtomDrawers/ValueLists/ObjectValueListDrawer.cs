#if UNITY_2019_1_OR_NEWER
using Plugins.UnityAtomsUtils.ValueLists;
using UnityAtoms.Editor;
using UnityEditor;

namespace Plugins.UnityAtomsUtils.Editor.AtomDrawers.ValueLists
{
    /// <summary>
    /// Value List property drawer of type `Object`. Inherits from `AtomDrawer&lt;ObjectValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ObjectValueList))]
    public class ObjectValueListDrawer : AtomDrawer<ObjectValueList> { }
}
#endif
