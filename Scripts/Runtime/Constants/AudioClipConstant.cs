using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Constants
{
    /// <summary>
    /// Constant of type `AudioClip`. Inherits from `AtomBaseVariable&lt;AudioClip&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    [CreateAssetMenu(menuName = "Unity Atoms/Constants/AudioClip", fileName = "AudioClipConstant")]
    public sealed class AudioClipConstant : AtomBaseVariable<AudioClip> { }
}
