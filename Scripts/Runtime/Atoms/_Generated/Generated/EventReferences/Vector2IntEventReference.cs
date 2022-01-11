using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     Event Reference of type `UnityEngine.Vector2Int`. Inherits from `AtomEventReference&lt;UnityEngine.Vector2Int,
    ///     Vector2IntVariable, Vector2IntEvent, Vector2IntVariableInstancer, Vector2IntEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class Vector2IntEventReference : AtomEventReference<
        Vector2Int,
        Vector2IntVariable,
        Vector2IntEvent,
        Vector2IntVariableInstancer,
        Vector2IntEventInstancer>, IGetEvent { }
}