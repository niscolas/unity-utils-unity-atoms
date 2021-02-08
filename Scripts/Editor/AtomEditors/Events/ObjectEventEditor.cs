#if UNITY_2019_1_OR_NEWER
using Plugins.UnityAtomsUtils.Events;
using UnityAtoms.Editor;
using UnityEditor;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Editor.AtomEditors.Events
{
    /// <summary>
    /// Event property drawer of type `Object`. Inherits from `AtomEventEditor&lt;Object, ObjectEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(ObjectEvent))]
    public sealed class ObjectEventEditor : AtomEventEditor<Object, ObjectEvent> { }
}
#endif
