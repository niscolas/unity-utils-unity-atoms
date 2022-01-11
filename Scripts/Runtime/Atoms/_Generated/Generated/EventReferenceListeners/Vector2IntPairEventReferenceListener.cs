using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     Event Reference Listener of type `Vector2IntPair`. Inherits from `AtomEventReferenceListener&lt;Vector2IntPair,
    ///     Vector2IntPairEvent, Vector2IntPairEventReference, Vector2IntPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Vector2IntPair Event Reference Listener")]
    public sealed class Vector2IntPairEventReferenceListener : AtomEventReferenceListener<
        Vector2IntPair,
        Vector2IntPairEvent,
        Vector2IntPairEventReference,
        Vector2IntPairUnityEvent> { }
}