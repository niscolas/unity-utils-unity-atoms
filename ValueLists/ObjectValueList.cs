using Plugins.UnityAtomsUtils.Events;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.ValueLists
{
    /// <summary>
    /// Value List of type `Object`. Inherits from `AtomValueList&lt;Object, ObjectEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Object", fileName = "ObjectValueList")]
    public sealed class ObjectValueList : AtomValueList<Object, ObjectEvent> { }
}
