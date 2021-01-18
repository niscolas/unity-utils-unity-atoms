using NaughtyAttributes;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Conditions.CheckEquals {
	[EditorIcon("atom-icon-teal")]
	public abstract class BaseCheckEquals<TO1, TO2, TP> : AtomCondition<TP> {
		[SerializeField]
		protected bool checkIfIsNotEqual;

		[SerializeField]
		protected bool useFixedOperand1;

		[ShowIf(nameof(useFixedOperand1))]
		[SerializeField]
		protected TO1 operand1;

		[SerializeField]
		protected TO2 operand2;

		protected abstract bool CheckEqualsDynamic(TP value1, TO2 value2);
		protected abstract bool CheckEqualsStatic(TO1 value1, TO2 value2);

		public override bool Call(TP dynamicValue) {
			bool result;
			
			result = useFixedOperand1 
				? CheckEqualsStatic(operand1, operand2) 
				: CheckEqualsDynamic(dynamicValue, operand2);

			return checkIfIsNotEqual ? !result : result;
		}
	}
}