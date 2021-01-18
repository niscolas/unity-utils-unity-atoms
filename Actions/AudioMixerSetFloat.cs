using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Audio;

namespace Plugins.UnityAtomsUtils.Actions {
	[CreateAssetMenu(
		menuName = AtomsConstants.ActionsCreateAssetMenuPath + "(float) => Audio Mixer Set Float",
		order = AtomsConstants.CreateAssetMenuOrder)]
	public class AudioMixerSetFloat : FloatAction {
		[SerializeField]
		private StringReference exposedParamNameRef;

		[SerializeField]
		private AudioMixer audioMixer;

		public override void Do(float value) {
			audioMixer.SetFloat(exposedParamNameRef.Value, value);
		}
	}
}