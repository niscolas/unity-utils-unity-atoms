using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.ConditionsCreateAssetMenuPrefix + "(Vector2) => Equals?")]
    public class CheckEqualsVector2AtomCondition :
        BaseCheckEqualsAtomCondition<Vector2Reference, Vector2Reference, Vector2>
    {
        protected override bool Inner_Call(Vector2 operand2)
        {
            return _operand1.Value == operand2;
        }

        protected override Vector2 GetConverted(Vector2Reference fixedOperand2)
        {
            return fixedOperand2.Value;
        }
    }
}