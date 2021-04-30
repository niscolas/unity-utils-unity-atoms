using System;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtomsUtils.Actions.MathOperation
{
	[EditorIcon("atom-icon-purple")]
	[CreateAssetMenu(menuName = Constants.ActionsCreateAssetMenuPath + "(int) => Math Operation")]
	public class IntMathOperation : BaseMathOperation<IntVariable, IntReference, int>
	{
		protected override void Inner_Do(int operand2)
		{
			switch (mathOperation)
			{
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

		protected override int GetConverted(IntReference fixedOperand2)
		{
			return fixedOperand2.Value;
		}
	}
}