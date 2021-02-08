using Plugins.UnityAtomsUtils.Pairs;
using Plugins.UnityAtomsUtils.Variables;
using UnityAtoms.Editor;
using UnityEditor;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Editor.AtomEditors.Variables
{
    /// <summary>
    /// Variable Inspector of type `AudioClip`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(AudioClipVariable))]
    public sealed class AudioClipVariableEditor : AtomVariableEditor<AudioClip, AudioClipPair> { }
}
