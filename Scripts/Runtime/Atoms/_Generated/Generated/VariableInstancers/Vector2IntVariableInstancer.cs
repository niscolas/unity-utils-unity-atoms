using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     Variable Instancer of type `UnityEngine.Vector2Int`. Inherits from `AtomVariableInstancer&lt;Vector2IntVariable,
    ///     Vector2IntPair, UnityEngine.Vector2Int, Vector2IntEvent, Vector2IntPairEvent, Vector2IntVector2IntFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Vector2Int Variable Instancer")]
    public class Vector2IntVariableInstancer : AtomVariableInstancer<
        Vector2IntVariable,
        Vector2IntPair,
        Vector2Int,
        Vector2IntEvent,
        Vector2IntPairEvent,
        Vector2IntVector2IntFunction> { }
}