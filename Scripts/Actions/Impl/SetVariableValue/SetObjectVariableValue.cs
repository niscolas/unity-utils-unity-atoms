using Plugins.UnityAtomsUtils.Constants;
using Plugins.UnityAtomsUtils.Events;
using Plugins.UnityAtomsUtils.Functions;
using Plugins.UnityAtomsUtils.Pairs;
using Plugins.UnityAtomsUtils.References;
using Plugins.UnityAtomsUtils.VariableInstancers;
using Plugins.UnityAtomsUtils.Variables;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Actions.Impl.SetVariableValue
{
    /// <summary>
    /// Set variable value Action of type `Object`. Inherits from `SetVariableValue&lt;Object, ObjectPair, ObjectVariable, ObjectConstant, ObjectReference, ObjectEvent, ObjectPairEvent, ObjectVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Object", fileName = "SetObjectVariableValue")]
    public sealed class SetObjectVariableValue : SetVariableValue<
        Object,
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
