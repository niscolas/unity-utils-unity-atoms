using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `UnityEngine.Vector2Int`. Inherits from `AtomEventReferenceListener&lt;UnityEngine.Vector2Int, Vector2IntEvent, Vector2IntEventReference, Vector2IntUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Vector2Int Event Reference Listener")]
    public sealed class Vector2IntEventReferenceListener : AtomEventReferenceListener<
        UnityEngine.Vector2Int,
        Vector2IntEvent,
        Vector2IntEventReference,
        Vector2IntUnityEvent>
    { }
}
