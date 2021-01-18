using System;
using Plugins.MathUtils;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Actions {
	[EditorIcon("atom-icon-purple")]
	[CreateAssetMenu(menuName = AtomsConstants.ActionsCreateAssetMenuPath + "Int Float Math Operation")]
	public class PerformIntFloatMathOperation : PerformMathOperationBase<
		int,
		IntPair,
		IntConstant,
		IntVariable,
		IntEvent,
		IntPairEvent,
		IntIntFunction,
		IntVariableInstancer,
		FloatReference> {
		public override void Do() {
			switch (mathOperation) {
				case BasicMathOperation.Sum:
					operand1.Add((int) operand2.Value);
					break;

				case BasicMathOperation.Subtract:
					operand1.Subtract((int) operand2.Value);
					break;

				case BasicMathOperation.Divide:
					operand1.DivideBy((int) operand2.Value);
					break;

				case BasicMathOperation.Multiply:
					operand1.MultiplyBy((int) operand2.Value);
					break;

				default:
					throw new ArgumentOutOfRangeException();
			}
		}
	}
}