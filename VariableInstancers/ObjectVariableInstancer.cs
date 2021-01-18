using Plugins.UnityAtomsUtils.Events;
using Plugins.UnityAtomsUtils.Functions;
using Plugins.UnityAtomsUtils.Pairs;
using Plugins.UnityAtomsUtils.Variables;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.VariableInstancers
{
    /// <summary>
    /// Variable Instancer of type `Object`. Inherits from `AtomVariableInstancer&lt;ObjectVariable, ObjectPair, Object, ObjectEvent, ObjectPairEvent, ObjectObjectFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Object Variable Instancer")]
    public class ObjectVariableInstancer : AtomVariableInstancer<
        ObjectVariable,
        ObjectPair,
        Object,
        ObjectEvent,
        ObjectPairEvent,
        ObjectObjectFunction>
    { }
}
