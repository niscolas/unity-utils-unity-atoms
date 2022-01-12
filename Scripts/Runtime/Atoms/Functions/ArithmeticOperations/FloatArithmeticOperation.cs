using System;
using niscolas.UnityUtils;
using niscolas.UnityUtils.Core;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.FunctionsCreateAssetMenuPrefix + "(float) => Arithmetic Operation : float")]
    public class FloatArithmeticOperation : FloatFloatFunction
    {
        [SerializeField]
        private ArithmeticOperation<FloatReference> _operation;

        public override float Call(float dynamicOperand1)
        {
            return ComputeOperationResult(dynamicOperand1);
        }

        public float Call()
        {
            return ComputeOperationResult(_operation.FixedOperand1.Value);
        }

        private float ComputeOperationResult(float operand1)
        {
            float operand2 = _operation.Operand2.Value;

            switch (_operation.Operator)
            {
                case ArithmeticalOperator.Sum:
                    return operand1 + operand2;

                case ArithmeticalOperator.Subtract:
                    return operand1 - operand2;

                case ArithmeticalOperator.Divide:
                    return operand1 / operand2;

                case ArithmeticalOperator.Multiply:
                    return operand1 * operand2;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}