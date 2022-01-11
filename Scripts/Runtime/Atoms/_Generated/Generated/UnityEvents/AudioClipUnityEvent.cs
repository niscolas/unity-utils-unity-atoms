using System;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     None generic Unity Event of type `UnityEngine.AudioClip`. Inherits from `UnityEvent&lt;UnityEngine.AudioClip&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AudioClipUnityEvent : UnityEvent<AudioClip> { }
}