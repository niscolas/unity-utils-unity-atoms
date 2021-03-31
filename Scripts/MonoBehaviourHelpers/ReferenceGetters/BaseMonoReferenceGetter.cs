using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Plugins.Scripts.MonoBehaviourHelpers.ReferenceGetters
{
	public abstract class BaseMonoReferenceGetter<T, P, C, V, E1, E2, F, VI, R> : MonoBehaviour
		where R : AtomReference<T, P, C, V, E1, E2, F, VI>
		where P : struct, IPair<T>
		where C : AtomBaseVariable<T>
		where V : AtomVariable<T, P, E1, E2, F>
		where E1 : AtomEvent<T>
		where E2 : AtomEvent<P>
		where F : AtomFunction<T, T>
		where VI : AtomVariableInstancer<V, P, T, E1, E2, F>
	{
		[SerializeField]
		private R valueRef;

		[SerializeField]
		private UnityEvent<T> onGet;

		public void Get()
		{
			if (valueRef == null)
			{
				return;
			}

			onGet?.Invoke(valueRef.Value);
		}
	}
}