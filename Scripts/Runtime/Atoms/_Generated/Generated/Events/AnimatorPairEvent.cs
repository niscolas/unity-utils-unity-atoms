using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `AnimatorPair`. Inherits from `AtomEvent&lt;AnimatorPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/AnimatorPair", fileName = "AnimatorPairEvent")]
    public sealed class AnimatorPairEvent : AtomEvent<AnimatorPair>
    {
    }
}
