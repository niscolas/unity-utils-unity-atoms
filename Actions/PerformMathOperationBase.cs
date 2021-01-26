using Plugins.MathUtils;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Actions {
	[EditorIcon("atom-icon-purple")]
	public abstract class PerformMathOperationBase<T, P, C, V, E1, E2, F, VI, R> : AtomAction
		where P : struct, IPair<T>
		where C : AtomBaseVariable<T>
		where V : AtomVariable<T, P, E1, E2, F>
		where E1 : AtomEvent<T>
		where E2 : AtomEvent<P>
		where F : AtomFunction<T, T>
		where VI : AtomVariableInstancer<V, P, T, E1, E2, F>
		where R : AtomBaseReference {
		[SerializeField]
		protected V operand1;

		[SerializeField]
		protected MathOperation mathOperation;

		[SerializeField]
		protected R operand2;
	}
}