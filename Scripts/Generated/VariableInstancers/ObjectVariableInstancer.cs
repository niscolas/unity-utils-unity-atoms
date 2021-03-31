using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Variable Instancer of type `UnityEngine.Object`. Inherits from `AtomVariableInstancer&lt;ObjectVariable, ObjectPair, UnityEngine.Object, ObjectEvent, ObjectPairEvent, ObjectObjectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Object Variable Instancer")]
    public class ObjectVariableInstancer : AtomVariableInstancer<
        ObjectVariable,
        ObjectPair,
        UnityEngine.Object,
        ObjectEvent,
        ObjectPairEvent,
        ObjectObjectFunction>
    { }
}
