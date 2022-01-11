using UnityAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    public abstract class BaseCheckEqualsAtomCondition<TOp1, TFixedOp2, TDynamicOp2> :
        AtomCondition<TDynamicOp2>
    {
        [SerializeField]
        protected bool _invert;

        [SerializeField]
        protected TOp1 _operand1;

        [SerializeField]
        private TFixedOp2 _fixedOperand2;

        protected abstract TDynamicOp2 GetConverted(TFixedOp2 fixedOperand2);

        protected abstract bool Inner_Call(TDynamicOp2 operand2);

        public override bool Call(TDynamicOp2 dynamicOp2)
        {
            return Internal_Call(dynamicOp2);
        }

        public bool Call()
        {
            return Internal_Call(GetConverted(_fixedOperand2));
        }

        private bool Internal_Call(TDynamicOp2 operand2)
        {
            bool result = Inner_Call(operand2);
            return _invert ? !result : result;
        }
    }
}