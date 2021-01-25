using System;
using Plugins.UnityAtomsUtils.EventInstancers;
using Plugins.UnityAtomsUtils.Events;
using Plugins.UnityAtomsUtils.Pairs;
using Plugins.UnityAtomsUtils.VariableInstancers;
using Plugins.UnityAtomsUtils.Variables;
using UnityAtoms;

namespace Plugins.UnityAtomsUtils.EventReferences
{
    /// <summary>
    /// Event Reference of type `AudioClipPair`. Inherits from `AtomEventReference&lt;AudioClipPair, AudioClipVariable, AudioClipPairEvent, AudioClipVariableInstancer, AudioClipPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AudioClipPairEventReference : AtomEventReference<
        AudioClipPair,
        AudioClipVariable,
        AudioClipPairEvent,
        AudioClipVariableInstancer,
        AudioClipPairEventInstancer>, IGetEvent 
    { }
}
