using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Conditions.Impl.Compare {
	[EditorIcon("atom-icon-teal")]
	[CreateAssetMenu(menuName = AtomsConstants.ConditionsCreateAssetMenuPath + "(int) => Compare?")]
	public class CompareInt : BaseCompare<IntReference, IntReference, int> {
		protected override bool Inner_Call(int operand2) {
			return operand1.Value == operand2;
		}

		protected override int GetConverted(IntReference fixedOperand2) {
			return fixedOperand2.Value;
		}
	}
}