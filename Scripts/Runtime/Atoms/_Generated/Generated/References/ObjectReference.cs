using System;
using Object = UnityEngine.Object;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     Reference of type `UnityEngine.Object`. Inherits from `AtomReference&lt;UnityEngine.Object, ObjectPair,
    ///     ObjectConstant, ObjectVariable, ObjectEvent, ObjectPairEvent, ObjectObjectFunction, ObjectVariableInstancer,
    ///     AtomCollection, AtomList&gt;`.
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
        ObjectVariableInstancer>, IEquatable<ObjectReference>
    {
        public ObjectReference() { }
        public ObjectReference(Object value) : base(value) { }

        public bool Equals(ObjectReference other)
        {
            return base.Equals(other);
        }

        protected override bool ValueEquals(Object other)
        {
            throw new NotImplementedException();
        }
    }
}