using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable of type `UnityEngine.Object`. Inherits from `AtomVariable&lt;UnityEngine.Object, ObjectPair, ObjectEvent, ObjectPairEvent, ObjectObjectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Object", fileName = "ObjectVariable")]
    public sealed class ObjectVariable : AtomVariable<UnityEngine.Object, ObjectPair, ObjectEvent, ObjectPairEvent, ObjectObjectFunction>
    {
        protected override bool ValueEquals(UnityEngine.Object other)
        {
            throw new NotImplementedException();
        }
    }
}
