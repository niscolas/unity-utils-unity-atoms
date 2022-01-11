using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     Event of type `ObjectPair`. Inherits from `AtomEvent&lt;ObjectPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/ObjectPair", fileName = "ObjectPairEvent")]
    public sealed class ObjectPairEvent : AtomEvent<ObjectPair> { }
}