using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `UnityEngine.Animator`. Inherits from `UnityEvent&lt;UnityEngine.Animator&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AnimatorUnityEvent : UnityEvent<UnityEngine.Animator> { }
}
