using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Animator`. Inherits from `AtomEventReferenceListener&lt;Animator, AnimatorEvent, AnimatorEventReference, AnimatorUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Animator Event Reference Listener")]
    public sealed class AnimatorEventReferenceListener : AtomEventReferenceListener<
        Animator,
        AnimatorEvent,
        AnimatorEventReference,
        AnimatorUnityEvent>
    { }
}
