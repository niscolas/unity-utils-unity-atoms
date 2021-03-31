using System;
using UnityEngine.Events;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// None generic Unity Event of type `ObjectPair`. Inherits from `UnityEvent&lt;ObjectPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ObjectPairUnityEvent : UnityEvent<ObjectPair> { }
}
