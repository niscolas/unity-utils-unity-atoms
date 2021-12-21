using niscolas.UnityUtils.Core;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(menuName = UnityAtomsConstants.ConditionsCreateAssetMenuPrefix + "(int) => Compare?")]
    public class CompareInt : BaseCompare<IntReference, IntReference, int>
    {
        protected override bool Inner_Call(int operand2)
        {
            int operand1Value = _operand1.Value;
            bool result = ComparisonUtility.Compare(operand1Value, _comparisonOperator, operand2);

            return result;
        }

        protected override int GetConverted(IntReference fixedOperand2)
        {
            return fixedOperand2.Value;
        }
    }
}