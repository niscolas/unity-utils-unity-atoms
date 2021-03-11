using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `Animator`. Inherits from `AtomEvent&lt;Animator&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Animator", fileName = "AnimatorEvent")]
    public sealed class AnimatorEvent : AtomEvent<Animator>
    {
    }
}
