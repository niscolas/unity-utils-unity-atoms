using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(menuName =
        Constants.ConditionsCreateAssetMenuPrefix + "(GameObject) => Equals?")]
    public class
        CheckEqualsGameObjectAtomCondition : BaseCheckEqualsAtomCondition<GameObjectReference, GameObjectReference,
            GameObject>
    {
        protected override bool Inner_Call(GameObject operand2)
        {
            return _operand1.Value == operand2;
        }

        protected override GameObject GetConverted(GameObjectReference fixedOperand2)
        {
            return fixedOperand2.Value;
        }
    }
}