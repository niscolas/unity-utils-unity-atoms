using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Conditions.Impl {
	[EditorIcon("atom-icon-teal")]
	[CreateAssetMenu(menuName = AtomsConstants.ConditionsCreateAssetMenuPath + "(bool) => Check")]
	public class CheckBool : BoolCondition {
		[SerializeField]
		private bool invert;

		public override bool Call(bool value) {
			return invert ? !value : value;
		}
	}
}