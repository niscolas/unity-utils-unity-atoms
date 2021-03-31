using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `UnityEngine.Animator`. Inherits from `AtomVariableInstancer&lt;AnimatorVariable, AnimatorPair, UnityEngine.Animator, AnimatorEvent, AnimatorPairEvent, AnimatorAnimatorFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Animator Variable Instancer")]
    public class AnimatorVariableInstancer : AtomVariableInstancer<
        AnimatorVariable,
        AnimatorPair,
        UnityEngine.Animator,
        AnimatorEvent,
        AnimatorPairEvent,
        AnimatorAnimatorFunction>
    { }
}
