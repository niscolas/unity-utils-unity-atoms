using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `AudioClipPair`. Inherits from `AtomEventReference&lt;AudioClipPair, AudioClipVariable, AudioClipPairEvent, AudioClipVariableInstancer, AudioClipPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AudioClipPairEventReference : AtomEventReference<
        AudioClipPair,
        AudioClipVariable,
        AudioClipPairEvent,
        AudioClipVariableInstancer,
        AudioClipPairEventInstancer>, IGetEvent 
    { }
}
