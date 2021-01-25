using System;
using Plugins.UnityAtomsUtils.EventInstancers;
using Plugins.UnityAtomsUtils.Events;
using Plugins.UnityAtomsUtils.VariableInstancers;
using Plugins.UnityAtomsUtils.Variables;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.EventReferences
{
    /// <summary>
    /// Event Reference of type `AudioClip`. Inherits from `AtomEventReference&lt;AudioClip, AudioClipVariable, AudioClipEvent, AudioClipVariableInstancer, AudioClipEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AudioClipEventReference : AtomEventReference<
        AudioClip,
        AudioClipVariable,
        AudioClipEvent,
        AudioClipVariableInstancer,
        AudioClipEventInstancer>, IGetEvent 
    { }
}
