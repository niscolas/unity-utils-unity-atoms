using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Events
{
    /// <summary>
    /// Event of type `Object`. Inherits from `AtomEvent&lt;Object&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Object", fileName = "ObjectEvent")]
    public sealed class ObjectEvent : AtomEvent<Object>
    {
    }
}
