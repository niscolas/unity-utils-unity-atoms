#if UNITY_2019_1_OR_NEWER
using UnityAtoms.Editor;
using UnityEditor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    ///     Event property drawer of type `AudioClipPair`. Inherits from `AtomEventEditor&lt;AudioClipPair, AudioClipPairEvent
    ///     &gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(AudioClipPairEvent))]
    public sealed class AudioClipPairEventEditor : AtomEventEditor<AudioClipPair, AudioClipPairEvent> { }
}
#endif