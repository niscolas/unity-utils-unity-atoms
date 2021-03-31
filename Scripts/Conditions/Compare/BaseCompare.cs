using MathUtils;
using UnityAtoms;
using UnityEngine;

namespace Plugins.Scripts.Conditions.Compare
{
	[EditorIcon("atom-icon-teal")]
	public abstract class BaseCompare<TOp1, TFixedOp2, TDynamicOp2> : AtomCondition<TDynamicOp2>
	{
		[SerializeField]
		protected TOp1 _operand1;

		[SerializeField]
		protected ComparisonOperator _comparisonOperator;

		[Header("Fixed Operand 2")]
		[SerializeField]
		private bool _useFixedOperand2;

		[SerializeField]
		private TFixedOp2 _fixedOperand2;

		protected abstract bool Inner_Call(TDynamicOp2 operand2);

		protected abstract TDynamicOp2 GetConverted(TFixedOp2 fixedOperand2);

		public sealed override bool Call(TDynamicOp2 dynamicOperand2)
		{
			bool result;
			if (!_useFixedOperand2)
			{
				result = Inner_Call(dynamicOperand2);
			}
			else
			{
				result = Call();
			}

			return result;
		}

		public bool Call()
		{
			TDynamicOp2 fixedOperand2 = GetConverted(_fixedOperand2);
			bool result = Inner_Call(fixedOperand2);

			return result;
		}
	}
}