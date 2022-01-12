using System;
using niscolas.UnityUtils;
using niscolas.UnityUtils.Core;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [Serializable]
    public struct ArithmeticOperation<T>
    {
        [SerializeField]
        private T _fixedOperand1;

        [SerializeField]
        private ArithmeticalOperator _operator;

        [SerializeField]
        private T _operand2;

        public T FixedOperand1 => _fixedOperand1;

        public ArithmeticalOperator Operator => _operator;

        public T Operand2 => _operand2;
    }
}