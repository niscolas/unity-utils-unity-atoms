#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `AudioClipPair`. Inherits from `AtomDrawer&lt;AudioClipPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AudioClipPairEvent))]
    public class AudioClipPairEventDrawer : AtomDrawer<AudioClipPairEvent> { }
}
#endif
