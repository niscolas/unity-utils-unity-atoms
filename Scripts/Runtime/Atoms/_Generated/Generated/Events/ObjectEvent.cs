using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     Event of type `UnityEngine.Object`. Inherits from `AtomEvent&lt;UnityEngine.Object&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Object", fileName = "ObjectEvent")]
    public sealed class ObjectEvent : AtomEvent<Object> { }
}