#if UNITY_2019_1_OR_NEWER
using UnityAtoms.Editor;
using UnityEditor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    ///     Value List property drawer of type `UnityEngine.Object`. Inherits from `AtomDrawer&lt;ObjectValueList&gt;`. Only
    ///     availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ObjectValueList))]
    public class ObjectValueListDrawer : AtomDrawer<ObjectValueList> { }
}
#endif