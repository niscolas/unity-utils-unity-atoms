using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `ObjectPair`. Inherits from `AtomEventInstancer&lt;ObjectPair, ObjectPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/ObjectPair Event Instancer")]
    public class ObjectPairEventInstancer : AtomEventInstancer<ObjectPair, ObjectPairEvent> { }
}
