#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ObjectPair`. Inherits from `AtomDrawer&lt;ObjectPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ObjectPairEvent))]
    public class ObjectPairEventDrawer : AtomDrawer<ObjectPairEvent> { }
}
#endif
