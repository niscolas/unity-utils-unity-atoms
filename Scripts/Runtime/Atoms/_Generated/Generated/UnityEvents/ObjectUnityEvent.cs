using System;
using UnityEngine.Events;
using Object = UnityEngine.Object;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     None generic Unity Event of type `UnityEngine.Object`. Inherits from `UnityEvent&lt;UnityEngine.Object&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ObjectUnityEvent : UnityEvent<Object> { }
}