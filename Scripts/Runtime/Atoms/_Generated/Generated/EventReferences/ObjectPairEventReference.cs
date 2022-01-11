using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     Event Reference of type `ObjectPair`. Inherits from `AtomEventReference&lt;ObjectPair, ObjectVariable,
    ///     ObjectPairEvent, ObjectVariableInstancer, ObjectPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class ObjectPairEventReference : AtomEventReference<
        ObjectPair,
        ObjectVariable,
        ObjectPairEvent,
        ObjectVariableInstancer,
        ObjectPairEventInstancer>, IGetEvent { }
}