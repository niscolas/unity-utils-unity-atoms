using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Plugins.Scripts.MonoBehaviourHelpers.MonoInputInterpreters
{
	public abstract class BaseMonoInputInterpreter<T, P, C, V, E1, E2, EI, ER, F, VI, R> : MonoBehaviour
		where T : struct
		where P : struct, IPair<T>
		where C : AtomBaseVariable<T>
		where V : AtomVariable<T, P, E1, E2, F>
		where E1 : AtomEvent<T>
		where E2 : AtomEvent<P>
		where EI : AtomEventInstancer<T, E1>
		where ER : AtomEventReference<T, V, E1, VI, EI>
		where F : AtomFunction<T, T>
		where VI : AtomVariableInstancer<V, P, T, E1, E2, F>
		where R : AtomReference<T, P, C, V, E1, E2, F, VI>
	{
		[SerializeField]
		private ER started;

		[SerializeField]
		private ER performed;

		[SerializeField]
		private ER canceled;

		[SerializeField]
		private ER waiting;

		[SerializeField]
		private ER disabled;

		[SerializeField]
		private R valueRef;

		[SerializeField]
		private BoolReference valueAsButton;

		public void Interpret(InputAction.CallbackContext context)
		{
			Raise(context);
			UpdateValues(context);
		}

		public void Raise(InputAction.CallbackContext context)
		{
			T value = context.ReadValue<T>();
			switch (context.phase)
			{
				case InputActionPhase.Disabled:
					if (disabled?.Event)
					{
						disabled?.Event.Raise(value);
					}

					break;

				case InputActionPhase.Waiting:
					if (waiting?.Event)
					{
						waiting?.Event.Raise(value);
					}

					break;

				case InputActionPhase.Started:
					if (started?.Event)
					{
						started?.Event.Raise(value);
					}

					break;

				case InputActionPhase.Performed:
					if (performed?.Event)
					{
						performed?.Event.Raise(value);
					}

					break;

				case InputActionPhase.Canceled:
					if (canceled?.Event)
					{
						canceled?.Event.Raise(value);
					}

					break;
			}
		}

		public void UpdateValues(InputAction.CallbackContext context)
		{
			if (valueRef != null)
			{
				valueRef.Value = context.ReadValue<T>();
			}

			if (!valueAsButton.IsUnassigned)
			{
				valueAsButton.Value = context.ReadValueAsButton();
			}
		}
	}
}