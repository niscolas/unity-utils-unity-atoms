using Plugins.UnityAtomsUtils.EventReferences;
using Plugins.UnityAtomsUtils.Events;
using Plugins.UnityAtomsUtils.UnityEvents;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.EventReferenceListeners
{
    /// <summary>
    /// Event Reference Listener of type `Object`. Inherits from `AtomEventReferenceListener&lt;Object, ObjectEvent, ObjectEventReference, ObjectUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Object Event Reference Listener")]
    public sealed class ObjectEventReferenceListener : AtomEventReferenceListener<
        Object,
        ObjectEvent,
        ObjectEventReference,
        ObjectUnityEvent>
    { }
}
