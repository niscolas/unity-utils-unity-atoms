using UnityEditor;
using UnityAtoms.Editor;
using UnityEngine;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Animator`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(AnimatorVariable))]
    public sealed class AnimatorVariableEditor : AtomVariableEditor<Animator, AnimatorPair> { }
}
