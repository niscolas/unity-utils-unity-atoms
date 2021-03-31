using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `UnityEngine.Animator`. Inherits from `AtomEvent&lt;UnityEngine.Animator&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Animator", fileName = "AnimatorEvent")]
    public sealed class AnimatorEvent : AtomEvent<UnityEngine.Animator>
    {
    }
}
