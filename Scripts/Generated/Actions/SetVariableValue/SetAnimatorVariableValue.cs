using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `UnityEngine.Animator`. Inherits from `SetVariableValue&lt;UnityEngine.Animator, AnimatorPair, AnimatorVariable, AnimatorConstant, AnimatorReference, AnimatorEvent, AnimatorPairEvent, AnimatorVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Animator", fileName = "SetAnimatorVariableValue")]
    public sealed class SetAnimatorVariableValue : SetVariableValue<
        UnityEngine.Animator,
        AnimatorPair,
        AnimatorVariable,
        AnimatorConstant,
        AnimatorReference,
        AnimatorEvent,
        AnimatorPairEvent,
        AnimatorAnimatorFunction,
        AnimatorVariableInstancer>
    { }
}
