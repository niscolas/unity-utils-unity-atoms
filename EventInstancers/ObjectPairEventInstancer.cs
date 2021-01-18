using Plugins.UnityAtomsUtils.Events;
using Plugins.UnityAtomsUtils.Pairs;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.EventInstancers
{
    /// <summary>
    /// Event Instancer of type `ObjectPair`. Inherits from `AtomEventInstancer&lt;ObjectPair, ObjectPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/ObjectPair Event Instancer")]
    public class ObjectPairEventInstancer : AtomEventInstancer<ObjectPair, ObjectPairEvent> { }
}
