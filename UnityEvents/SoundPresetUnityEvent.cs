using System;
using Plugins.AudioUtils;
using UnityEngine.Events;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `SoundPreset`. Inherits from `UnityEvent&lt;SoundPreset&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SoundPresetUnityEvent : UnityEvent<SoundPreset> { }
}
