using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Animator`. Inherits from `AtomReference&lt;Animator, AnimatorPair, AnimatorConstant, AnimatorVariable, AnimatorEvent, AnimatorPairEvent, AnimatorAnimatorFunction, AnimatorVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AnimatorReference : AtomReference<
        Animator,
        AnimatorPair,
        AnimatorConstant,
        AnimatorVariable,
        AnimatorEvent,
        AnimatorPairEvent,
        AnimatorAnimatorFunction,
        AnimatorVariableInstancer>, IEquatable<AnimatorReference>
    {
        public AnimatorReference() : base() { }
        public AnimatorReference(Animator value) : base(value) { }
        public bool Equals(AnimatorReference other) { return base.Equals(other); }
        protected override bool ValueEquals(Animator other)
        {
            throw new NotImplementedException();
        }
    }
}
