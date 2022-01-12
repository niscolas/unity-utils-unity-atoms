using niscolas.UnityUtils.Core;
using UnityAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    public abstract class BaseMathOperationAtomAction<TOp1, TFixedOp2, TDynamicOp2> : AtomAction<TDynamicOp2>
        where TOp1 : AtomBaseVariable
    {
        [SerializeField]
        protected TOp1 _operand1;

        [SerializeField]
        protected ArithmeticalOperator _arithmeticalOperator;

        [SerializeField]
        private TFixedOp2 _fixedOperand2;

        protected abstract void Inner_Do(TDynamicOp2 operand2);

        protected abstract TDynamicOp2 GetConverted(TFixedOp2 fixedOperand2);

        public sealed override void Do(TDynamicOp2 dynamicOperand2)
        {
            Inner_Do(dynamicOperand2);
        }

        public sealed override void Do()
        {
            Inner_Do(GetConverted(_fixedOperand2));
        }
    }
}