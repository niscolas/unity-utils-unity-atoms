using System;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     Variable of type `UnityEngine.AudioClip`. Inherits from `AtomVariable&lt;UnityEngine.AudioClip, AudioClipPair,
    ///     AudioClipEvent, AudioClipPairEvent, AudioClipAudioClipFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/AudioClip", fileName = "AudioClipVariable")]
    public sealed class AudioClipVariable : AtomVariable<AudioClip, AudioClipPair, AudioClipEvent, AudioClipPairEvent,
        AudioClipAudioClipFunction>
    {
        protected override bool ValueEquals(AudioClip other)
        {
            throw new NotImplementedException();
        }
    }
}