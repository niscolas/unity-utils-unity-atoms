#if UNITY_2019_1_OR_NEWER
using Plugins.UnityAtomsUtils.Events;
using UnityAtoms.Editor;
using UnityEditor;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Editor.AtomEditors.Events
{
    /// <summary>
    /// Event property drawer of type `AudioClip`. Inherits from `AtomEventEditor&lt;AudioClip, AudioClipEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(AudioClipEvent))]
    public sealed class AudioClipEventEditor : AtomEventEditor<AudioClip, AudioClipEvent> { }
}
#endif
