using System;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     Event Reference of type `Vector2IntPair`. Inherits from `AtomEventReference&lt;Vector2IntPair, Vector2IntVariable,
    ///     Vector2IntPairEvent, Vector2IntVariableInstancer, Vector2IntPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector2IntPairEventReference : AtomEventReference<
        Vector2IntPair,
        Vector2IntVariable,
        Vector2IntPairEvent,
        Vector2IntVariableInstancer,
        Vector2IntPairEventInstancer>, IGetEvent { }
}