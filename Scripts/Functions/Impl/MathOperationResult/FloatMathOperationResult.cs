using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Functions.Impl.MathOperationResult {
	[CreateAssetMenu(
		menuName = AtomsConstants.FunctionsCreateAssetMenuPath + "(float) => Math Operation : float",
		order = AtomsConstants.CreateAssetMenuOrder)]
	public class FloatMathOperationResult : BaseMathOperationResult<
		FloatReference, FloatReference, float, float> {
		protected override float Inner_Call(float operand2) {
			return mathOperation switch {
				MathUtils.MathOperation.Sum => operand1.Value + operand2,
				MathUtils.MathOperation.Subtract => operand1.Value - operand2,
				MathUtils.MathOperation.Divide => operand1.Value / operand2,
				MathUtils.MathOperation.Multiply => operand1.Value * operand2,
				_ => throw new ArgumentOutOfRangeException()
			};
		}

		protected override float GetConverted(FloatReference fixedOperand2) {
			throw new NotImplementedException();
		}
	}
}