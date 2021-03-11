using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Conditions
{
    /// <summary>
    /// Condition of type `AudioClip`. Inherits from `AtomCondition&lt;AudioClip&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-teal")]
    public abstract class AudioClipCondition : AtomCondition<AudioClip> { }
}