using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Conditions.Impl.CheckEquals {
	[EditorIcon("atom-icon-teal")]
	public abstract class BaseCheckEquals<TOp1, TFixedOp2, TDynamicOp2> : AtomCondition<TDynamicOp2> {
		[SerializeField]
		protected TOp1 operand1;

		[SerializeField]
		protected bool invert;

		[SerializeField]
		private TFixedOp2 fixedOperand2;

		protected abstract bool Inner_Call(TDynamicOp2 operand2);

		protected abstract TDynamicOp2 GetConverted(TFixedOp2 fixedOperand2);

		public override bool Call(TDynamicOp2 dynamicOp2) {
			return Internal_Call(dynamicOp2);
		}

		public bool Call() {
			return Internal_Call(GetConverted(fixedOperand2));
		}

		private bool Internal_Call(TDynamicOp2 operand2) {
			bool result = Inner_Call(operand2);
			return invert ? !result : result;
		}
	}
}