using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Functions.Impl.MathOperationResult {
	public abstract class
		BaseMathOperationResult<TOp1, TFixedOp2, TReturn, TDynamicOp2> : AtomFunction<TReturn, TDynamicOp2> {
		[SerializeField]
		protected TOp1 operand1;

		[SerializeField]
		protected MathUtils.MathOperation mathOperation;

		[SerializeField]
		private TFixedOp2 fixedOperand2;

		protected abstract TReturn Inner_Call(TDynamicOp2 operand2);
		protected abstract TDynamicOp2 GetConverted(TFixedOp2 fixedOperand2);

		public sealed override TReturn Call(TDynamicOp2 dynamicOperand2) {
			return Inner_Call(dynamicOperand2);
		}

		public TReturn Call() {
			return Inner_Call(GetConverted(fixedOperand2));
		}
	}
}