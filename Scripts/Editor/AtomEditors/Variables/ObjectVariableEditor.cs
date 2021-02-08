using Plugins.UnityAtomsUtils.Pairs;
using Plugins.UnityAtomsUtils.Variables;
using UnityAtoms.Editor;
using UnityEditor;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Editor.AtomEditors.Variables
{
    /// <summary>
    /// Variable Inspector of type `Object`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(ObjectVariable))]
    public sealed class ObjectVariableEditor : AtomVariableEditor<Object, ObjectPair> { }
}
