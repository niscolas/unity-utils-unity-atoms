using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     Set variable value Action of type `UnityEngine.AudioClip`. Inherits from `SetVariableValue&lt;
    ///     UnityEngine.AudioClip, AudioClipPair, AudioClipVariable, AudioClipConstant, AudioClipReference, AudioClipEvent,
    ///     AudioClipPairEvent, AudioClipVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/AudioClip",
        fileName = "SetAudioClipVariableValue")]
    public sealed class SetAudioClipVariableValue : SetVariableValue<
        AudioClip,
        AudioClipPair,
        AudioClipVariable,
        AudioClipConstant,
        AudioClipReference,
        AudioClipEvent,
        AudioClipPairEvent,
        AudioClipAudioClipFunction,
        AudioClipVariableInstancer> { }
}