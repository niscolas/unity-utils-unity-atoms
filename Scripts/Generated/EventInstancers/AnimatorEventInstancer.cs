using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `UnityEngine.Animator`. Inherits from `AtomEventInstancer&lt;UnityEngine.Animator, AnimatorEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Animator Event Instancer")]
    public class AnimatorEventInstancer : AtomEventInstancer<UnityEngine.Animator, AnimatorEvent> { }
}
