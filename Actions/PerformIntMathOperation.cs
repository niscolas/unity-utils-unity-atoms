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
				case BasicMathOperation.Sum:
					operand1.Add(operand2);
					break;

				case BasicMathOperation.Subtract:
					operand1.Subtract(operand2);
					break;

				case BasicMathOperation.Divide:
					operand1.DivideBy(operand2);
					break;

				case BasicMathOperation.Multiply:
					operand1.MultiplyBy(operand2);
					break;

				default:
					throw new ArgumentOutOfRangeException();
			}
		}
	}
}