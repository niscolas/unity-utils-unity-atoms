using System.Collections.Generic;
using System.Linq;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.MonoBehaviourHelpers.TagEventRaiser {
	public class TagEventRaiser<T, P, C, V, E1, E2, F, VI, R, EI> : BaseTagEventRaiser<T, E1, EI>
		where P : struct, IPair<T>
		where C : AtomBaseVariable<T>
		where V : AtomVariable<T, P, E1, E2, F>
		where E1 : AtomEvent<T>
		where E2 : AtomEvent<P>
		where F : AtomFunction<T, T>
		where VI : AtomVariableInstancer<V, P, T, E1, E2, F>
		where R : AtomReference<T, P, C, V, E1, E2, F, VI>
		where EI : AtomEventInstancer<T, E1> {
		[SerializeField]
		private R fixedValue;

		public void Raise(GameObject baseGameObject) {
			Raise(baseGameObject, fixedValue);
		}
	}
}