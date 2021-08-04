using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `AnimatorPair`. Inherits from `AtomEventInstancer&lt;AnimatorPair, AnimatorPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/AnimatorPair Event Instancer")]
    public class AnimatorPairEventInstancer : AtomEventInstancer<AnimatorPair, AnimatorPairEvent> { }
}
