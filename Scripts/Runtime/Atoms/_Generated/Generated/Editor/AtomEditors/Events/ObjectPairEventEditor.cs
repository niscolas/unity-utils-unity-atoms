#if UNITY_2019_1_OR_NEWER
using UnityAtoms.Editor;
using UnityEditor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    ///     Event property drawer of type `ObjectPair`. Inherits from `AtomEventEditor&lt;ObjectPair, ObjectPairEvent&gt;`.
    ///     Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ObjectPairEvent))]
    public sealed class ObjectPairEventEditor : AtomEventEditor<ObjectPair, ObjectPairEvent> { }
}
#endif