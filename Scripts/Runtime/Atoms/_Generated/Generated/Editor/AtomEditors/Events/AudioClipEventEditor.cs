#if UNITY_2019_1_OR_NEWER
using UnityAtoms.Editor;
using UnityEditor;
using UnityEngine;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    ///     Event property drawer of type `UnityEngine.AudioClip`. Inherits from `AtomEventEditor&lt;UnityEngine.AudioClip,
    ///     AudioClipEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(AudioClipEvent))]
    public sealed class AudioClipEventEditor : AtomEventEditor<AudioClip, AudioClipEvent> { }
}
#endif