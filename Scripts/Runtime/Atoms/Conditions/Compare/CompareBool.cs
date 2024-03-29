﻿using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(menuName = Constants.ConditionsCreateAssetMenuPrefix + "(bool) => Compare?")]
    public class CompareBool : BaseCompare<BoolReference, BoolReference, bool>
    {
        protected override bool Inner_Call(bool operand2)
        {
            bool operand1Value = _operand1.Value;
            bool result = operand1Value == operand2;
            return result;
        }

        protected override bool GetConverted(BoolReference fixedOperand2)
        {
            return fixedOperand2.Value;
        }
    }
}