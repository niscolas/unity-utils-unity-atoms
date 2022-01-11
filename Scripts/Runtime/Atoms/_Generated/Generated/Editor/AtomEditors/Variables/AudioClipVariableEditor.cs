using UnityAtoms.Editor;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    ///     Variable Inspector of type `UnityEngine.AudioClip`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(AudioClipVariable))]
    public sealed class AudioClipVariableEditor : AtomVariableEditor<AudioClip, AudioClipPair> { }
}