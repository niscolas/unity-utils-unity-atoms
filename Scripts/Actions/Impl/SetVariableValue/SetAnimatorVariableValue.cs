using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Actions.Impl.SetVariableValue
{
    /// <summary>
    /// Set variable value Action of type `Animator`. Inherits from `SetVariableValue&lt;Animator, AnimatorPair, AnimatorVariable, AnimatorConstant, AnimatorReference, AnimatorEvent, AnimatorPairEvent, AnimatorVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Animator", fileName = "SetAnimatorVariableValue")]
    public sealed class SetAnimatorVariableValue : SetVariableValue<
        Animator,
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
