﻿using niscolas.UnityUtils.Core;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(menuName = Constants.ConditionsCreateAssetMenuPrefix + "(float) => Compare?")]
    public class CompareFloat : BaseCompare<FloatReference, FloatReference, float>
    {
        protected override bool Inner_Call(float operand2)
        {
            float operand1Value = _operand1.Value;
            bool result = ComparisonUtility.Compare(operand1Value, _comparisonOperator, operand2);

            return result;
        }

        protected override float GetConverted(FloatReference fixedOperand2)
        {
            return fixedOperand2.Value;
        }
    }
}