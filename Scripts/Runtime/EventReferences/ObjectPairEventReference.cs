using System;
using Plugins.UnityAtomsUtils.EventInstancers;
using Plugins.UnityAtomsUtils.Events;
using Plugins.UnityAtomsUtils.Pairs;
using Plugins.UnityAtomsUtils.VariableInstancers;
using Plugins.UnityAtomsUtils.Variables;
using UnityAtoms;

namespace Plugins.UnityAtomsUtils.EventReferences
{
    /// <summary>
    /// Event Reference of type `ObjectPair`. Inherits from `AtomEventReference&lt;ObjectPair, ObjectVariable, ObjectPairEvent, ObjectVariableInstancer, ObjectPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ObjectPairEventReference : AtomEventReference<
        ObjectPair,
        ObjectVariable,
        ObjectPairEvent,
        ObjectVariableInstancer,
        ObjectPairEventInstancer>, IGetEvent 
    { }
}
