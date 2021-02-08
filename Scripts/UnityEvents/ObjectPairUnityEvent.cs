using System;
using Plugins.UnityAtomsUtils.Pairs;
using UnityEngine.Events;

namespace Plugins.UnityAtomsUtils.UnityEvents
{
    /// <summary>
    /// None generic Unity Event of type `ObjectPair`. Inherits from `UnityEvent&lt;ObjectPair&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ObjectPairUnityEvent : UnityEvent<ObjectPair> { }
}
