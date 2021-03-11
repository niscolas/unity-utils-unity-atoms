using Plugins.UnityAtomsUtils.EventReferences;
using Plugins.UnityAtomsUtils.Events;
using Plugins.UnityAtomsUtils.Pairs;
using Plugins.UnityAtomsUtils.UnityEvents;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.EventReferenceListeners
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
