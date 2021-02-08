using Plugins.MathUtils;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Conditions.Impl.Compare {
	[EditorIcon("atom-icon-teal")]
	public abstract class BaseCompare<TOp1, TFixedOp2, TDynamicOp2> : AtomCondition<TDynamicOp2> {
		[SerializeField]
		protected TOp1 operand1;

		[SerializeField]
		protected ComparisonOperator comparisonOperator;

		[SerializeField]
		private TFixedOp2 fixedOperand2;

		protected abstract bool Inner_Call(TDynamicOp2 operand2);

		protected abstract TDynamicOp2 GetConverted(TFixedOp2 fixedOperand2);

		public sealed override bool Call(TDynamicOp2 dynamicOperand2) {
			return Inner_Call(dynamicOperand2);
		}

		public bool Call() {
			return Inner_Call(GetConverted(fixedOperand2));
		}
	}
}