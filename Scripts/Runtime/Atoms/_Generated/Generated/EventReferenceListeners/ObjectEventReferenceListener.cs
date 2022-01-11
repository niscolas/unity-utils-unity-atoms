using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     Event Reference Listener of type `UnityEngine.Object`. Inherits from `AtomEventReferenceListener&lt;
    ///     UnityEngine.Object, ObjectEvent, ObjectEventReference, ObjectUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Object Event Reference Listener")]
    public sealed class ObjectEventReferenceListener : AtomEventReferenceListener<
        Object,
        ObjectEvent,
        ObjectEventReference,
        ObjectUnityEvent> { }
}