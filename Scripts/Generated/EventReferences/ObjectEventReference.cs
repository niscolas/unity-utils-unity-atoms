using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference of type `UnityEngine.Object`. Inherits from `AtomEventReference&lt;UnityEngine.Object, ObjectVariable, ObjectEvent, ObjectVariableInstancer, ObjectEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ObjectEventReference : AtomEventReference<
        UnityEngine.Object,
        ObjectVariable,
        ObjectEvent,
        ObjectVariableInstancer,
        ObjectEventInstancer>, IGetEvent 
    { }
}
