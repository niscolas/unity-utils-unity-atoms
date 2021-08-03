using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `ObjectPair`. Inherits from `AtomEventReferenceListener&lt;ObjectPair, ObjectPairEvent, ObjectPairEventReference, ObjectPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/ObjectPair Event Reference Listener")]
    public sealed class ObjectPairEventReferenceListener : AtomEventReferenceListener<
        ObjectPair,
        ObjectPairEvent,
        ObjectPairEventReference,
        ObjectPairUnityEvent>
    { }
}
