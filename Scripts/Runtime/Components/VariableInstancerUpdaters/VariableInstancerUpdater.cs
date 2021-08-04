using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.VariableInstancerUpdater
{
	public class VariableInstancerUpdater<V, P, T, E1, E2, F, TVi> : MonoBehaviour
		where V : AtomVariable<T, P, E1, E2, F>
		where P : struct, IPair<T>
		where E1 : AtomEvent<T>
		where E2 : AtomEvent<P>
		where F : AtomFunction<T, T>
		where TVi : AtomVariableInstancer<V, P, T, E1, E2, F>
	{
		[SerializeField]
		private TVi _instancer;

		private E1 _instancerEvent;

		private void Awake()
		{
			if (!_instancer)
			{
				_instancer = GetComponent<TVi>();

				if (!_instancer) return;
			}

			_instancerEvent = _instancer.Base.GetOrCreateEvent<E1>();

			if (!_instancerEvent) return;

			_instancerEvent.Register(UpdateInstancerVariableCopyValue);
		}

		private void OnDestroy()
		{
			if (!_instancerEvent) return;

			_instancerEvent.Unregister(UpdateInstancerVariableCopyValue);
		}

		private void UpdateInstancerVariableCopyValue(T newValue)
		{
			_instancer.Value = newValue;
		}
	}
}