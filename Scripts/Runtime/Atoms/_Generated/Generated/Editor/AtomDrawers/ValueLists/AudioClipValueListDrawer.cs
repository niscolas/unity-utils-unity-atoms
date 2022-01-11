#if UNITY_2019_1_OR_NEWER
using UnityAtoms.Editor;
using UnityEditor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    ///     Value List property drawer of type `UnityEngine.AudioClip`. Inherits from `AtomDrawer&lt;AudioClipValueList&gt;`.
    ///     Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AudioClipValueList))]
    public class AudioClipValueListDrawer : AtomDrawer<AudioClipValueList> { }
}
#endif