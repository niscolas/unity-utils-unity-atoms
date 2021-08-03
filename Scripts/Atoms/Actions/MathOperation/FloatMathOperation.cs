using System;
using niscolas.UnityUtils.Core;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(menuName = Constants.ActionsCreateAssetMenuPath + "(float) => Math Operation")]
    public class FloatMathOperation : BaseMathOperation<FloatVariable, FloatReference, float>
    {
        protected override void Inner_Do(float operand2)
        {
            switch (mathOperation)
            {
                case ArithmeticalOperator.Sum:
                    operand1.Add(operand2);
                    break;

                case ArithmeticalOperator.Subtract:
                    operand1.Subtract(operand2);
                    break;

                case ArithmeticalOperator.Divide:
                    operand1.DivideBy(operand2);
                    break;

                case ArithmeticalOperator.Multiply:
                    operand1.MultiplyBy(operand2);
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        protected override float GetConverted(FloatReference fixedOperand2)
        {
            return fixedOperand2.Value;
        }
    }
}