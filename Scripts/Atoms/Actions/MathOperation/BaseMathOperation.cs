using niscolas.UnityUtils.Core;
using UnityAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    public abstract class BaseMathOperation<TOp1, TFixedOp2, TDynamicOp2> : AtomAction<TDynamicOp2>
        where TOp1 : AtomBaseVariable
    {
        [SerializeField]
        protected TOp1 operand1;

        [SerializeField]
        protected ArithmeticalOperator mathOperation;

        [SerializeField]
        private TFixedOp2 fixedOperand2;

        protected abstract void Inner_Do(TDynamicOp2 operand2);

        protected abstract TDynamicOp2 GetConverted(TFixedOp2 fixedOperand2);

        public sealed override void Do(TDynamicOp2 dynamicOperand2)
        {
            Inner_Do(dynamicOperand2);
        }

        public sealed override void Do()
        {
            Inner_Do(GetConverted(fixedOperand2));
        }
    }
}