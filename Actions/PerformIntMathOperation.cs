using System;
using Plugins.MathUtils;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Actions {
	[EditorIcon("atom-icon-purple")]
	[CreateAssetMenu(menuName = AtomsConstants.ActionsCreateAssetMenuPath + "Int Math Operation")]
	public class PerformIntMathOperation : PerformMathOperationBase<
		int,
		IntPair,
		IntConstant,
		IntVariable,
		IntEvent,
		IntPairEvent,
		IntIntFunction,
		IntVariableInstancer,
		IntReference> {
		public override void Do() {
			switch (mathOperation) {
				case MathOperation.Sum:
					operand1.Add(operand2);
					break;

				case MathOperation.Subtract:
					operand1.Subtract(operand2);
					break;

				case MathOperation.Divide:
					operand1.DivideBy(operand2);
					break;

				case MathOperation.Multiply:
					operand1.MultiplyBy(operand2);
					break;

				default:
					throw new ArgumentOutOfRangeException();
			}
		}
	}
}