using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `UnityEngine.Animator`. Inherits from `AtomVariable&lt;UnityEngine.Animator, AnimatorPair, AnimatorEvent, AnimatorPairEvent, AnimatorAnimatorFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Animator", fileName = "AnimatorVariable")]
    public sealed class AnimatorVariable : AtomVariable<UnityEngine.Animator, AnimatorPair, AnimatorEvent, AnimatorPairEvent, AnimatorAnimatorFunction>
    {
        protected override bool ValueEquals(UnityEngine.Animator other)
        {
            throw new NotImplementedException();
        }
    }
}
