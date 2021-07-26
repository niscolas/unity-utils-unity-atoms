using System;
using System.Linq;
using MathUtils;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityAtomsUtils.Conditions.Compare;
using UnityEngine;

namespace UnityAtomsUtils.Utilities
{

	[Serializable]
	public class ComparisonWrapperGroup
	{
		[SerializeField]
		private CompareFloat[] _comparisons;

		[SerializeField]
		private AtomConditionOperators _operator;

		public bool CompareAll()
		{
			return CompareAll(0, false);
		}

		public bool CompareAll(float operand2, bool useOperand2 = true)
		{
			bool CompareSingle(CompareFloat comparison)
			{
				if (useOperand2)
				{
					return comparison.Call(operand2);
				}

				return comparison.Call();
			}

			switch (_operator)
			{
				case AtomConditionOperators.And:

					return _comparisons.All(CompareSingle);

				case AtomConditionOperators.Or:
					return _comparisons.Any(CompareSingle);

				default:
					throw new ArgumentOutOfRangeException();
			}
		}
	}
}