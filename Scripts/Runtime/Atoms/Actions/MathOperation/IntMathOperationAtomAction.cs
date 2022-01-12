using System;
using niscolas.UnityUtils;
using niscolas.UnityUtils.Core;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.ActionsCreateAssetMenuPrefix + "(int) => Math Operation",
        order = Constants.CreateAssetMenuOrder)]
    public class IntMathOperationAtomAction : BaseMathOperationAtomAction<IntVariable, IntReference, int>
    {
        protected override void Inner_Do(int operand2)
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

        protected override int GetConverted(IntReference fixedOperand2)
        {
            return fixedOperand2.Value;
        }
    }
}