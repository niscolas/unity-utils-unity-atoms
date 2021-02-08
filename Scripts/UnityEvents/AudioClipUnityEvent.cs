using System;
using UnityEngine;
using UnityEngine.Events;

namespace Plugins.UnityAtomsUtils.UnityEvents
{
    /// <summary>
    /// None generic Unity Event of type `AudioClip`. Inherits from `UnityEvent&lt;AudioClip&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AudioClipUnityEvent : UnityEvent<AudioClip> { }
}
