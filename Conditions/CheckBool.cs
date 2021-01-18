using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Conditions {
	[EditorIcon("atom-icon-teal")]
	[CreateAssetMenu(menuName = AtomsConstants.ConditionsCreateAssetMenuPath + "Check Bool")]
	public class CheckBool : BoolCondition {
		[SerializeField]
		private bool invert;

		public override bool Call(bool value) {
			return invert ? !value : value;
		}
	}
}