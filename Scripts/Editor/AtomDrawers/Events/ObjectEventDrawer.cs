#if UNITY_2019_1_OR_NEWER
using Plugins.UnityAtomsUtils.Events;
using UnityAtoms.Editor;
using UnityEditor;

namespace Plugins.UnityAtomsUtils.Editor.AtomDrawers.Events
{
    /// <summary>
    /// Event property drawer of type `Object`. Inherits from `AtomDrawer&lt;ObjectEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ObjectEvent))]
    public class ObjectEventDrawer : AtomDrawer<ObjectEvent> { }
}
#endif
