using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `UnityEngine.Animator`. Inherits from `AtomEventReferenceListener&lt;UnityEngine.Animator, AnimatorEvent, AnimatorEventReference, AnimatorUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Animator Event Reference Listener")]
    public sealed class AnimatorEventReferenceListener : AtomEventReferenceListener<
        UnityEngine.Animator,
        AnimatorEvent,
        AnimatorEventReference,
        AnimatorUnityEvent>
    { }
}
