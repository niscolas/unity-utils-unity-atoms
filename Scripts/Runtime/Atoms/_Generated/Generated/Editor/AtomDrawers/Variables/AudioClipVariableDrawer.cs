#if UNITY_2019_1_OR_NEWER
using UnityAtoms.Editor;
using UnityEditor;

namespace UnityAtoms.BaseAtoms.Editor
{
    /// <summary>
    ///     Variable property drawer of type `UnityEngine.AudioClip`. Inherits from `AtomDrawer&lt;AudioClipVariable&gt;`. Only
    ///     availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AudioClipVariable))]
    public class AudioClipVariableDrawer : VariableDrawer<AudioClipVariable> { }
}
#endif