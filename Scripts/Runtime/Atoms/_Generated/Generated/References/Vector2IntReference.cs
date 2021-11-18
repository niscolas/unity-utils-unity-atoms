using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `UnityEngine.Vector2Int`. Inherits from `AtomReference&lt;UnityEngine.Vector2Int, Vector2IntPair, Vector2IntConstant, Vector2IntVariable, Vector2IntEvent, Vector2IntPairEvent, Vector2IntVector2IntFunction, Vector2IntVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector2IntReference : AtomReference<
        UnityEngine.Vector2Int,
        Vector2IntPair,
        Vector2IntConstant,
        Vector2IntVariable,
        Vector2IntEvent,
        Vector2IntPairEvent,
        Vector2IntVector2IntFunction,
        Vector2IntVariableInstancer>, IEquatable<Vector2IntReference>
    {
        public Vector2IntReference() : base() { }
        public Vector2IntReference(UnityEngine.Vector2Int value) : base(value) { }
        public bool Equals(Vector2IntReference other) { return base.Equals(other); }
        protected override bool ValueEquals(UnityEngine.Vector2Int other)
        {
            throw new NotImplementedException();
        }
    }
}
