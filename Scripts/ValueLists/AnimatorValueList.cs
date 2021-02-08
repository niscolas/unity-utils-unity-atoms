using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `Animator`. Inherits from `AtomValueList&lt;Animator, AnimatorEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Animator", fileName = "AnimatorValueList")]
    public sealed class AnimatorValueList : AtomValueList<Animator, AnimatorEvent> { }
}
