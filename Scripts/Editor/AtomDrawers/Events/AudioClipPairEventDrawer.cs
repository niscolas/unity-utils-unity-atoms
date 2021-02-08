#if UNITY_2019_1_OR_NEWER
using Plugins.UnityAtomsUtils.Events;
using UnityAtoms.Editor;
using UnityEditor;

namespace Plugins.UnityAtomsUtils.Editor.AtomDrawers.Events
{
    /// <summary>
    /// Event property drawer of type `AudioClipPair`. Inherits from `AtomDrawer&lt;AudioClipPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AudioClipPairEvent))]
    public class AudioClipPairEventDrawer : AtomDrawer<AudioClipPairEvent> { }
}
#endif
