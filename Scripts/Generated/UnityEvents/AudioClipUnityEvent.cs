using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `UnityEngine.AudioClip`. Inherits from `UnityEvent&lt;UnityEngine.AudioClip&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AudioClipUnityEvent : UnityEvent<UnityEngine.AudioClip> { }
}
