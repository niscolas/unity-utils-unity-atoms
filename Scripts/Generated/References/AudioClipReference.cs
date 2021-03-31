using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Reference of type `UnityEngine.AudioClip`. Inherits from `AtomReference&lt;UnityEngine.AudioClip, AudioClipPair, AudioClipConstant, AudioClipVariable, AudioClipEvent, AudioClipPairEvent, AudioClipAudioClipFunction, AudioClipVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AudioClipReference : AtomReference<
        UnityEngine.AudioClip,
        AudioClipPair,
        AudioClipConstant,
        AudioClipVariable,
        AudioClipEvent,
        AudioClipPairEvent,
        AudioClipAudioClipFunction,
        AudioClipVariableInstancer>, IEquatable<AudioClipReference>
    {
        public AudioClipReference() : base() { }
        public AudioClipReference(UnityEngine.AudioClip value) : base(value) { }
        public bool Equals(AudioClipReference other) { return base.Equals(other); }
        protected override bool ValueEquals(UnityEngine.AudioClip other)
        {
            throw new NotImplementedException();
        }
    }
}
