using System;
using Plugins.UnityAtomsUtils.EventInstancers;
using Plugins.UnityAtomsUtils.Events;
using Plugins.UnityAtomsUtils.VariableInstancers;
using Plugins.UnityAtomsUtils.Variables;
using UnityAtoms;
using Object = UnityEngine.Object;

namespace Plugins.UnityAtomsUtils.EventReferences {
	/// <summary>
	/// Event Reference of type `Object`. Inherits from `AtomEventReference&lt;Object, ObjectVariable, ObjectEvent, ObjectVariableInstancer, ObjectEventInstancer&gt;`.
	/// </summary>
	[Serializable]
	public sealed class ObjectEventReference : AtomEventReference<
		Object,
		ObjectVariable,
		ObjectEvent,
		ObjectVariableInstancer,
		ObjectEventInstancer>, IGetEvent { }
}