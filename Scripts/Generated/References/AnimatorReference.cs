using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `UnityEngine.Animator`. Inherits from `AtomReference&lt;UnityEngine.Animator, AnimatorPair, AnimatorConstant, AnimatorVariable, AnimatorEvent, AnimatorPairEvent, AnimatorAnimatorFunction, AnimatorVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AnimatorReference : AtomReference<
        UnityEngine.Animator,
        AnimatorPair,
        AnimatorConstant,
        AnimatorVariable,
        AnimatorEvent,
        AnimatorPairEvent,
        AnimatorAnimatorFunction,
        AnimatorVariableInstancer>, IEquatable<AnimatorReference>
    {
        public AnimatorReference() : base() { }
        public AnimatorReference(UnityEngine.Animator value) : base(value) { }
        public bool Equals(AnimatorReference other) { return base.Equals(other); }
        protected override bool ValueEquals(UnityEngine.Animator other)
        {
            throw new NotImplementedException();
        }
    }
}
