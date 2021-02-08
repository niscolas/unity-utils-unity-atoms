using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Actions.Impl {
	[CreateAssetMenu(
		menuName = AtomsConstants.ActionsCreateAssetMenuPath + "(float) => Set Time Scale")]
	public class SetTimeScale : AtomAction<float> {
		public override void Do(float timeScale) {
			Time.timeScale = timeScale;
		}
	}
}