using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Conditions.CheckEquals {
	[EditorIcon("atom-icon-teal")]
	[CreateAssetMenu(menuName =
		AtomsConstants.ConditionsCreateAssetMenuPath + "Check Equals (Object - AtomBaseVariable)")]
	public class CheckEqualsObjectVariable : BaseCheckEquals<Object, AtomBaseVariable, UnityEngine.GameObject> {
		protected override bool CheckEqualsDynamic(UnityEngine.GameObject value1, AtomBaseVariable value2) {
			return value1 == (Object) value2.BaseValue;
		}

		protected override bool CheckEqualsStatic(Object value1, AtomBaseVariable value2) {
			return value1 == (Object) value2.BaseValue;
		}
	}
}