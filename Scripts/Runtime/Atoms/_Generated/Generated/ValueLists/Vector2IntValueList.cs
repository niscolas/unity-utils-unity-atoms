using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Value List of type `UnityEngine.Vector2Int`. Inherits from `AtomValueList&lt;UnityEngine.Vector2Int, Vector2IntEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Vector2Int", fileName = "Vector2IntValueList")]
    public sealed class Vector2IntValueList : AtomValueList<UnityEngine.Vector2Int, Vector2IntEvent> { }
}
