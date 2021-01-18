using System;
using NaughtyAttributes;
using Plugins.MathUtils;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Conditions.Compare {
	[EditorIcon("atom-icon-teal")]
	public abstract class CompareBase<T, P, C, V, E1, E2, F, VI, R, TP> : AtomCondition<TP>
		where R : AtomReference<T, P, C, V, E1, E2, F, VI>
		where P : struct, IPair<T>
		where C : AtomBaseVariable<T>
		where V : AtomVariable<T, P, E1, E2, F>
		where E1 : AtomEvent<T>
		where E2 : AtomEvent<P>
		where F : AtomFunction<T, T>
		where VI : AtomVariableInstancer<V, P, T, E1, E2, F>
		where T : IComparable {
		[SerializeField]
		private bool useFixedOperand1;

		[ShowIf(nameof(useFixedOperand1))]
		[SerializeField]
		protected R operand1;

		[SerializeField]
		protected ComparisonOperator comparisonOperator;

		[SerializeField]
		protected R operand2;
	}
}