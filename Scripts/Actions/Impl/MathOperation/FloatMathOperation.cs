using System;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Actions.Impl.MathOperation {
	[EditorIcon("atom-icon-purple")]
	[CreateAssetMenu(menuName = AtomsConstants.ActionsCreateAssetMenuPath + "(float) => Math Operation")]
	public class FloatMathOperation : BaseMathOperation<FloatVariable, FloatReference, float> {
		protected override void Inner_Do(float operand2) {
			switch (mathOperation) {
				case MathUtils.MathOperation.Sum:
					operand1.Add(operand2);
					break;

				case MathUtils.MathOperation.Subtract:
					operand1.Subtract(operand2);
					break;

				case MathUtils.MathOperation.Divide:
					operand1.DivideBy(operand2);
					break;

				case MathUtils.MathOperation.Multiply:
					operand1.MultiplyBy(operand2);
					break;

				default:
					throw new ArgumentOutOfRangeException();
			}
		}

		protected override float GetConverted(FloatReference fixedOperand2) {
			return fixedOperand2.Value;
		}
	}
}