using System;
using Plugins.MathUtils;
using UnityAtoms;
using Void = UnityAtoms.Void;

namespace Plugins.UnityAtomsUtils.Conditions.Compare {
	[EditorIcon("atom-icon-teal")]
	public class VoidCompareBase<T, P, C, V, E1, E2, F, VI, R> : CompareBase<T, P, C, V, E1, E2, F, VI, R, Void>
		where R : AtomReference<T, P, C, V, E1, E2, F, VI>
		where P : struct, IPair<T>
		where C : AtomBaseVariable<T>
		where V : AtomVariable<T, P, E1, E2, F>
		where E1 : AtomEvent<T>
		where E2 : AtomEvent<P>
		where F : AtomFunction<T, T>
		where VI : AtomVariableInstancer<V, P, T, E1, E2, F>
		where T : IComparable {
		public override bool Call(Void t1) {
			return Call();
		}
		
		public bool Call() {
			return ComparisonTypeUtility<T>.Compare(operand1, comparisonOperator, operand2);
		}
	}
}