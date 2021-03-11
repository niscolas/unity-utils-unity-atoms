using System;
using UnityEngine.Events;
using Object = UnityEngine.Object;

namespace Plugins.UnityAtomsUtils.UnityEvents {
	/// <summary>
	/// None generic Unity Event of type `Object`. Inherits from `UnityEvent&lt;Object&gt;`.
	/// </summary>
	[Serializable]
	public sealed class ObjectUnityEvent : UnityEvent<Object> { }
}