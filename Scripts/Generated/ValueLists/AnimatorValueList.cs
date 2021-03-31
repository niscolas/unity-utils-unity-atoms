using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `UnityEngine.Animator`. Inherits from `AtomValueList&lt;UnityEngine.Animator, AnimatorEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Animator", fileName = "AnimatorValueList")]
    public sealed class AnimatorValueList : AtomValueList<UnityEngine.Animator, AnimatorEvent> { }
}
