using Plugins.UnityAtomsUtils.Events;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.EventInstancers
{
    /// <summary>
    /// Event Instancer of type `Object`. Inherits from `AtomEventInstancer&lt;Object, ObjectEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/Object Event Instancer")]
    public class ObjectEventInstancer : AtomEventInstancer<Object, ObjectEvent> { }
}
