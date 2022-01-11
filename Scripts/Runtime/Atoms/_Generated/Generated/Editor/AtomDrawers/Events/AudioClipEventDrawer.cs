#if UNITY_2019_1_OR_NEWER
using UnityAtoms.Editor;
using UnityEditor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    ///     Event property drawer of type `UnityEngine.AudioClip`. Inherits from `AtomDrawer&lt;AudioClipEvent&gt;`. Only
    ///     availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AudioClipEvent))]
    public class AudioClipEventDrawer : AtomDrawer<AudioClipEvent> { }
}
#endif