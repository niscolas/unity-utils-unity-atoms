using Plugins.UnityAtomsUtils.Events;
using Plugins.UnityAtomsUtils.Functions;
using Plugins.UnityAtomsUtils.Pairs;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Variables {
	/// <summary>
	/// Variable of type `AudioClip`. Inherits from `AtomVariable&lt;AudioClip, AudioClipPair, AudioClipEvent, AudioClipPairEvent, AudioClipAudioClipFunction&gt;`.
	/// </summary>
	[EditorIcon("atom-icon-lush")]
	[CreateAssetMenu(menuName = "Unity Atoms/Variables/AudioClip", fileName = "AudioClipVariable")]
	public sealed class AudioClipVariable : AtomVariable<AudioClip, AudioClipPair, AudioClipEvent, AudioClipPairEvent,
		AudioClipAudioClipFunction> {
		protected override bool ValueEquals(AudioClip other) {
			return Value.Equals(other);
		}
	}
}