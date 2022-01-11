using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     Event Reference of type `UnityEngine.AudioClip`. Inherits from `AtomEventReference&lt;UnityEngine.AudioClip,
    ///     AudioClipVariable, AudioClipEvent, AudioClipVariableInstancer, AudioClipEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AudioClipEventReference : AtomEventReference<
        AudioClip,
        AudioClipVariable,
        AudioClipEvent,
        AudioClipVariableInstancer,
        AudioClipEventInstancer>, IGetEvent { }
}