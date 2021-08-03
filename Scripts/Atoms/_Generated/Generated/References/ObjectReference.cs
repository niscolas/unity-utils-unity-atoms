using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `UnityEngine.Object`. Inherits from `AtomReference&lt;UnityEngine.Object, ObjectPair, ObjectConstant, ObjectVariable, ObjectEvent, ObjectPairEvent, ObjectObjectFunction, ObjectVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ObjectReference : AtomReference<
        UnityEngine.Object,
        ObjectPair,
        ObjectConstant,
        ObjectVariable,
        ObjectEvent,
        ObjectPairEvent,
        ObjectObjectFunction,
        ObjectVariableInstancer>, IEquatable<ObjectReference>
    {
        public ObjectReference() : base() { }
        public ObjectReference(UnityEngine.Object value) : base(value) { }
        public bool Equals(ObjectReference other) { return base.Equals(other); }
        protected override bool ValueEquals(UnityEngine.Object other)
        {
            throw new NotImplementedException();
        }
    }
}
