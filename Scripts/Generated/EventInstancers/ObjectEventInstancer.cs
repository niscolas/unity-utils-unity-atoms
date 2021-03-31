using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Instancer of type `UnityEngine.Object`. Inherits from `AtomEventInstancer&lt;UnityEngine.Object, ObjectEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Object Event Instancer")]
    public class ObjectEventInstancer : AtomEventInstancer<UnityEngine.Object, ObjectEvent> { }
}
