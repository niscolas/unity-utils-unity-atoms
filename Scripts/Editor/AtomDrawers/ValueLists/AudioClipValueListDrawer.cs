#if UNITY_2019_1_OR_NEWER
using Plugins.UnityAtomsUtils.ValueLists;
using UnityAtoms.Editor;
using UnityEditor;

namespace Plugins.UnityAtomsUtils.Editor.AtomDrawers.ValueLists
{
    /// <summary>
    /// Value List property drawer of type `AudioClip`. Inherits from `AtomDrawer&lt;AudioClipValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AudioClipValueList))]
    public class AudioClipValueListDrawer : AtomDrawer<AudioClipValueList> { }
}
#endif
