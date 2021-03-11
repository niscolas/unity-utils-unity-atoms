using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Actions.Impl {
	[CreateAssetMenu(
		menuName = AtomsConstants.ActionsCreateAssetMenuPath + "(GameObject) => Set Position")]
	public class SetPosition : AtomAction<GameObject> {
		[SerializeField]
		private Vector3Variable targetPosition;

		public override void Do(GameObject entryValue) {
			entryValue.transform.position = targetPosition.Value;
		}
	}
}