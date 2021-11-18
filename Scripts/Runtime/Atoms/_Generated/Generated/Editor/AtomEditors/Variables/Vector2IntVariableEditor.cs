using UnityEditor;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `UnityEngine.Vector2Int`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(Vector2IntVariable))]
    public sealed class Vector2IntVariableEditor : AtomVariableEditor<UnityEngine.Vector2Int, Vector2IntPair> { }
}
