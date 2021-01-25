using Plugins.AudioUtils;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Actions {
	[EditorIcon("atom-icon-purple")]
	[CreateAssetMenu(
		menuName = AtomsConstants.ActionsCreateAssetMenuPath + "(SoundPreset) => Play",
		order = AtomsConstants.CreateAssetMenuOrder)]
	public class PlaySoundPreset : SoundPresetAction {
		[SerializeField]
		private SoundPresetReference fixedValue;

		public override void Do(SoundPreset dynamicValue) {
			AudioManager.Play(dynamicValue);
		}

		public override void Do() {
			AudioManager.Play(fixedValue);
		}
	}
}