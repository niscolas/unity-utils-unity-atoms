using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Set variable value Action of type `UnityEngine.Object`. Inherits from `SetVariableValue&lt;UnityEngine.Object, ObjectPair, ObjectVariable, ObjectConstant, ObjectReference, ObjectEvent, ObjectPairEvent, ObjectVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Object", fileName = "SetObjectVariableValue")]
    public sealed class SetObjectVariableValue : SetVariableValue<
        UnityEngine.Object,
        ObjectPair,
        ObjectVariable,
        ObjectConstant,
        ObjectReference,
        ObjectEvent,
        ObjectPairEvent,
        ObjectObjectFunction,
        ObjectVariableInstancer>
    { }
}
