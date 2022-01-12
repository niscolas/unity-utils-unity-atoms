using System;
using niscolas.UnityUtils.Core;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.ActionsCreateAssetMenuPrefix + "(float) => Math Operation",
        order = Constants.CreateAssetMenuOrder)]
    public class FloatMathOperationAtomAction : BaseMathOperationAtomAction<FloatVariable, FloatReference, float>
    {
        protected override void Inner_Do(float operand2)
        {
            switch (_arithmeticalOperator)
            {
                case ArithmeticalOperator.Sum:
                    _operand1.Add(operand2);
                    break;

                case ArithmeticalOperator.Subtract:
                    _operand1.Subtract(operand2);
                    break;

                case ArithmeticalOperator.Divide:
                    _operand1.DivideBy(operand2);
                    break;

                case ArithmeticalOperator.Multiply:
                    _operand1.MultiplyBy(operand2);
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