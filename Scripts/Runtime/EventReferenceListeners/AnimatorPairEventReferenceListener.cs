using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `AnimatorPair`. Inherits from `AtomEventReferenceListener&lt;AnimatorPair, AnimatorPairEvent, AnimatorPairEventReference, AnimatorPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/AnimatorPair Event Reference Listener")]
    public sealed class AnimatorPairEventReferenceListener : AtomEventReferenceListener<
        AnimatorPair,
        AnimatorPairEvent,
        AnimatorPairEventReference,
        AnimatorPairUnityEvent>
    { }
}
