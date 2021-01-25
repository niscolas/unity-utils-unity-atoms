using System;
using Plugins.UnityAtomsUtils.Constants;
using Plugins.UnityAtomsUtils.Events;
using Plugins.UnityAtomsUtils.Functions;
using Plugins.UnityAtomsUtils.Pairs;
using Plugins.UnityAtomsUtils.VariableInstancers;
using Plugins.UnityAtomsUtils.Variables;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.References
{
    /// <summary>
    /// Reference of type `AudioClip`. Inherits from `AtomReference&lt;AudioClip, AudioClipPair, AudioClipConstant, AudioClipVariable, AudioClipEvent, AudioClipPairEvent, AudioClipAudioClipFunction, AudioClipVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class AudioClipReference : AtomReference<
        AudioClip,
        AudioClipPair,
        AudioClipConstant,
        AudioClipVariable,
        AudioClipEvent,
        AudioClipPairEvent,
        AudioClipAudioClipFunction,
        AudioClipVariableInstancer>, IEquatable<AudioClipReference>
    {
        public AudioClipReference() : base() { }
        public AudioClipReference(AudioClip value) : base(value) { }
        public bool Equals(AudioClipReference other) { return base.Equals(other); }
        protected override bool ValueEquals(AudioClip other)
        {
            throw new NotImplementedException();
        }
    }
}
