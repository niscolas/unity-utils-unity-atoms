using Plugins.UnityAtomsUtils.Events;
using Plugins.UnityAtomsUtils.Functions;
using Plugins.UnityAtomsUtils.Pairs;
using Plugins.UnityAtomsUtils.Variables;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.VariableInstancers
{
    /// <summary>
    /// Variable Instancer of type `AudioClip`. Inherits from `AtomVariableInstancer&lt;AudioClipVariable, AudioClipPair, AudioClip, AudioClipEvent, AudioClipPairEvent, AudioClipAudioClipFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/AudioClip Variable Instancer")]
    public class AudioClipVariableInstancer : AtomVariableInstancer<
        AudioClipVariable,
        AudioClipPair,
        AudioClip,
        AudioClipEvent,
        AudioClipPairEvent,
        AudioClipAudioClipFunction>
    { }
}
