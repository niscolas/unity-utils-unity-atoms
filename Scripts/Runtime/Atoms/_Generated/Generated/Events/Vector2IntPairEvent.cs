using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `Vector2IntPair`. Inherits from `AtomEvent&lt;Vector2IntPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Vector2IntPair", fileName = "Vector2IntPairEvent")]
    public sealed class Vector2IntPairEvent : AtomEvent<Vector2IntPair>
    {
    }
}
