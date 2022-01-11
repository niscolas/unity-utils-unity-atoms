using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     Value List of type `UnityEngine.Object`. Inherits from `AtomValueList&lt;UnityEngine.Object, ObjectEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Object", fileName = "ObjectValueList")]
    public sealed class ObjectValueList : AtomValueList<Object, ObjectEvent> { }
}