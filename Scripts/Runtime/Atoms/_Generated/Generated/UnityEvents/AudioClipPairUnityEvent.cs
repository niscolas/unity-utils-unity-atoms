using System;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     None generic Unity Event of type `AudioClipPair`. Inherits from `UnityEvent&lt;AudioClipPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AudioClipPairUnityEvent : UnityEvent<AudioClipPair> { }
}