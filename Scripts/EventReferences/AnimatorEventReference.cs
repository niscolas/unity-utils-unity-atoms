using System;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `Animator`. Inherits from `AtomEventReference&lt;Animator, AnimatorVariable, AnimatorEvent, AnimatorVariableInstancer, AnimatorEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AnimatorEventReference : AtomEventReference<
        Animator,
        AnimatorVariable,
        AnimatorEvent,
        AnimatorVariableInstancer,
        AnimatorEventInstancer>, IGetEvent 
    { }
}
