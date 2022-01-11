using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     Variable of type `UnityEngine.Vector2Int`. Inherits from `AtomVariable&lt;UnityEngine.Vector2Int, Vector2IntPair,
    ///     Vector2IntEvent, Vector2IntPairEvent, Vector2IntVector2IntFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Vector2Int", fileName = "Vector2IntVariable")]
    public sealed class Vector2IntVariable : AtomVariable<Vector2Int, Vector2IntPair, Vector2IntEvent,
        Vector2IntPairEvent, Vector2IntVector2IntFunction>
    {
        protected override bool ValueEquals(Vector2Int other)
        {
            throw new NotImplementedException();
        }
    }
}