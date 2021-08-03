using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `UnityEngine.Animator`. Inherits from `AtomEventReference&lt;UnityEngine.Animator, AnimatorVariable, AnimatorEvent, AnimatorVariableInstancer, AnimatorEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AnimatorEventReference : AtomEventReference<
        UnityEngine.Animator,
        AnimatorVariable,
        AnimatorEvent,
        AnimatorVariableInstancer,
        AnimatorEventInstancer>, IGetEvent 
    { }
}
