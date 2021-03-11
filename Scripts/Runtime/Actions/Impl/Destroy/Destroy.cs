using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Actions.Impl.Destroy {
	[CreateAssetMenu(
		menuName = AtomsConstants.ActionsCreateAssetMenuPath +
		           "(GameObject) => Destroy")]
	public class Destroy : AtomAction<GameObject> {
		[SerializeField]
		private FloatReference delay;

		public override void Do(GameObject entryValue) {
			Destroy(entryValue, delay.Value);
		}
	}
}