using System;
using Plugins.MathUtils;
using UnityAtoms;

namespace Plugins.UnityAtomsUtils.Conditions.Compare {
	[EditorIcon("atom-icon-teal")]
	public abstract class
		NonVoidCompareBase<T, P, C, V, E1, E2, F, VI, R, TP> : CompareBase<T, P, C, V, E1, E2, F, VI, R, TP>
		where R : AtomReference<T, P, C, V, E1, E2, F, VI>
		where P : struct, IPair<T>
		where C : AtomBaseVariable<T>
		where V : AtomVariable<T, P, E1, E2, F>
		where E1 : AtomEvent<T>
		where E2 : AtomEvent<P>
		where F : AtomFunction<T, T>
		where VI : AtomVariableInstancer<V, P, T, E1, E2, F>
		where T : IComparable
		where TP : T {
		public override bool Call(TP parameterOperand) {
			return ComparisonTypeUtility<T>.Compare(parameterOperand, comparisonOperator, operand2);
		}
	}
}