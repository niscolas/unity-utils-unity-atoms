using UnityEngine;

namespace UnityAtoms {
	/// <summary>
	/// Variable of type `Animator`. Inherits from `AtomVariable&lt;Animator, AnimatorPair, AnimatorEvent, AnimatorPairEvent, AnimatorAnimatorFunction&gt;`.
	/// </summary>
	[EditorIcon("atom-icon-lush")]
	[CreateAssetMenu(menuName = "Unity Atoms/Variables/Animator", fileName = "AnimatorVariable")]
	public sealed class AnimatorVariable : AtomVariable<Animator, AnimatorPair, AnimatorEvent, AnimatorPairEvent,
		AnimatorAnimatorFunction> {
		protected override bool ValueEquals(Animator other) {
			return Value == other;
		}
	}
}