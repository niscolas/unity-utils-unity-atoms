#if UNITY_2019_1_OR_NEWER
using Plugins.UnityAtomsUtils.Variables;
using UnityAtoms.Editor;
using UnityEditor;

namespace Plugins.UnityAtomsUtils.Editor.AtomDrawers.Variables
{
    /// <summary>
    /// Variable property drawer of type `AudioClip`. Inherits from `AtomDrawer&lt;AudioClipVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(AudioClipVariable))]
    public class AudioClipVariableDrawer : VariableDrawer<AudioClipVariable> { }
}
#endif
