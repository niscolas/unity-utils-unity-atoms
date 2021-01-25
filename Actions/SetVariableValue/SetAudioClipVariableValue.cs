using Plugins.UnityAtomsUtils.Constants;
using Plugins.UnityAtomsUtils.Events;
using Plugins.UnityAtomsUtils.Functions;
using Plugins.UnityAtomsUtils.Pairs;
using Plugins.UnityAtomsUtils.References;
using Plugins.UnityAtomsUtils.VariableInstancers;
using Plugins.UnityAtomsUtils.Variables;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Actions.SetVariableValue
{
    /// <summary>
    /// Set variable value Action of type `AudioClip`. Inherits from `SetVariableValue&lt;AudioClip, AudioClipPair, AudioClipVariable, AudioClipConstant, AudioClipReference, AudioClipEvent, AudioClipPairEvent, AudioClipVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/AudioClip", fileName = "SetAudioClipVariableValue")]
    public sealed class SetAudioClipVariableValue : SetVariableValue<
        AudioClip,
        AudioClipPair,
        AudioClipVariable,
        AudioClipConstant,
        AudioClipReference,
        AudioClipEvent,
        AudioClipPairEvent,
        AudioClipAudioClipFunction,
        AudioClipVariableInstancer>
    { }
}
