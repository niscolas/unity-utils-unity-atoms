using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `UnityEngine.Vector2Int`. Inherits from `SetVariableValue&lt;UnityEngine.Vector2Int, Vector2IntPair, Vector2IntVariable, Vector2IntConstant, Vector2IntReference, Vector2IntEvent, Vector2IntPairEvent, Vector2IntVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Vector2Int", fileName = "SetVector2IntVariableValue")]
    public sealed class SetVector2IntVariableValue : SetVariableValue<
        UnityEngine.Vector2Int,
        Vector2IntPair,
        Vector2IntVariable,
        Vector2IntConstant,
        Vector2IntReference,
        Vector2IntEvent,
        Vector2IntPairEvent,
        Vector2IntVector2IntFunction,
        Vector2IntVariableInstancer>
    { }
}
