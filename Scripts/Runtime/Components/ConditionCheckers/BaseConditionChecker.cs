using Sirenix.OdinInspector;
using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace niscolas.UnityUtils.UnityAtoms
{
	public class BaseConditionChecker<T, P, C, V, E1, E2, F, VI, TR> : MonoBehaviour
		where TR : AtomReference<T, P, C, V, E1, E2, F, VI>
		where P : struct, IPair<T>
		where C : AtomBaseVariable<T>
		where V : AtomVariable<T, P, E1, E2, F>
		where E1 : AtomEvent<T>
		where E2 : AtomEvent<P>
		where F : AtomFunction<T, T>
		where VI : AtomVariableInstancer<V, P, T, E1, E2, F>
	{
		[SerializeField]
		private AtomCondition<T> _condition;

		[SerializeField]
		private TR _fixedInput;

		[Title("Events")]
		[SerializeField]
		private UnityEvent<T> _ifTrue;

		[SerializeField]
		private UnityEvent<T> _ifFalse;

		public void Check(T input)
		{
			bool conditionResult = _condition.Call(input);

			if (conditionResult)
			{
				_ifTrue?.Invoke(input);
				return;
			}

			_ifFalse?.Invoke(input);
		}

		public void Check()
		{
			T inputValue = default;

			if (_fixedInput != null)
			{
				inputValue = _fixedInput.Value;
			}

			Check(inputValue);
		}
	}
}