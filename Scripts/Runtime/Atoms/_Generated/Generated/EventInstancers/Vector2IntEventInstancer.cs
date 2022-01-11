using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     Event Instancer of type `UnityEngine.Vector2Int`. Inherits from `AtomEventInstancer&lt;UnityEngine.Vector2Int,
    ///     Vector2IntEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Vector2Int Event Instancer")]
    public class Vector2IntEventInstancer : AtomEventInstancer<Vector2Int, Vector2IntEvent> { }
}