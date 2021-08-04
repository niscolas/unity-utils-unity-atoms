using UnityEditor;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `UnityEngine.Animator`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(AnimatorVariable))]
    public sealed class AnimatorVariableEditor : AtomVariableEditor<UnityEngine.Animator, AnimatorPair> { }
}
