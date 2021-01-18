using Plugins.UnityAtomsUtils.Pairs;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Events
{
    /// <summary>
    /// Event of type `ObjectPair`. Inherits from `AtomEvent&lt;ObjectPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/ObjectPair", fileName = "ObjectPairEvent")]
    public sealed class ObjectPairEvent : AtomEvent<ObjectPair>
    {
    }
}
