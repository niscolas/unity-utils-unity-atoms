using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event of type `UnityEngine.Vector2Int`. Inherits from `AtomEvent&lt;UnityEngine.Vector2Int&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Vector2Int", fileName = "Vector2IntEvent")]
    public sealed class Vector2IntEvent : AtomEvent<UnityEngine.Vector2Int>
    {
    }
}
