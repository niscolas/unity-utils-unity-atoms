using UnityAtoms.Editor;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    ///     Variable Inspector of type `UnityEngine.Vector2Int`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(Vector2IntVariable))]
    public sealed class Vector2IntVariableEditor : AtomVariableEditor<Vector2Int, Vector2IntPair> { }
}