using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// None generic Unity Event of type `Animator`. Inherits from `UnityEvent&lt;Animator&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AnimatorUnityEvent : UnityEvent<Animator> { }
}
