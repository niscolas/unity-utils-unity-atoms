using UnityAtoms.Editor;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    ///     Variable Inspector of type `UnityEngine.Object`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(ObjectVariable))]
    public sealed class ObjectVariableEditor : AtomVariableEditor<Object, ObjectPair> { }
}