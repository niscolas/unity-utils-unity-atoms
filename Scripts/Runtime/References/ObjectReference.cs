using System;
using Plugins.UnityAtomsUtils.Constants;
using Plugins.UnityAtomsUtils.Events;
using Plugins.UnityAtomsUtils.Functions;
using Plugins.UnityAtomsUtils.Pairs;
using Plugins.UnityAtomsUtils.VariableInstancers;
using Plugins.UnityAtomsUtils.Variables;
using UnityAtoms;
using Object = UnityEngine.Object;

namespace Plugins.UnityAtomsUtils.References {
	/// <summary>
	/// Reference of type `Object`. Inherits from `AtomReference&lt;Object, ObjectPair, ObjectConstant, ObjectVariable, ObjectEvent, ObjectPairEvent, ObjectObjectFunction, ObjectVariableInstancer, AtomCollection, AtomList&gt;`.
	/// </summary>
	[Serializable]
	public sealed class ObjectReference : AtomReference<
		Object,
		ObjectPair,
		ObjectConstant,
		ObjectVariable,
		ObjectEvent,
		ObjectPairEvent,
		ObjectObjectFunction,
		ObjectVariableInstancer>, IEquatable<ObjectReference> {
		public ObjectReference() : base() { }
		public ObjectReference(Object value) : base(value) { }

		public bool Equals(ObjectReference other) {
			return base.Equals(other);
		}

		protected override bool ValueEquals(Object other) {
			throw new NotImplementedException();
		}
	}
}