using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `Animator`. Inherits from `AtomEventInstancer&lt;Animator, AnimatorEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Animator Event Instancer")]
    public class AnimatorEventInstancer : AtomEventInstancer<Animator, AnimatorEvent> { }
}
