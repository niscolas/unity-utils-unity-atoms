using System;
using Plugins.UnityAtomsUtils.Pairs;
using UnityEngine.Events;

namespace Plugins.UnityAtomsUtils.UnityEvents
{
    /// <summary>
    /// None generic Unity Event of type `AudioClipPair`. Inherits from `UnityEvent&lt;AudioClipPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AudioClipPairUnityEvent : UnityEvent<AudioClipPair> { }
}
