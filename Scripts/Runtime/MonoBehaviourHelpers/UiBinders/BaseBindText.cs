using TMPro;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Runtime.MonoBehaviourHelpers.UiBinders
{
	public abstract class BaseBindText<T, P, V, E1, E2, EI, ER, F, VI> : MonoBehaviour, IAtomListener<T>
		where P : struct, IPair<T>
		where V : AtomVariable<T, P, E1, E2, F>
		where E1 : AtomEvent<T>
		where E2 : AtomEvent<P>
		where EI : AtomEventInstancer<T, E1>
		where ER : AtomEventReference<T, V, E1, VI, EI>, new()
		where F : AtomFunction<T, T>
		where VI : AtomVariableInstancer<V, P, T, E1, E2, F>
	{
		[SerializeField]
		private TMP_Text _textComponent;

		[SerializeField]
		private ER _eventReference;

		[SerializeField]
		private bool _replayEventBuffer;

		[SerializeField]
		private V _variable;

		protected abstract string FormatText(T value);

		private void OnEnable()
		{
			RegisterSelf();
		}

		private void RegisterSelf()
		{
			if (_eventReference == null || _eventReference.Event == null) return;

			_eventReference.Event.RegisterListener(this, _replayEventBuffer);
		}

		public void OnEventRaised(T item)
		{
			UpdateText(item);
		}

		public void UpdateText(T dynamicValue)
		{
			string text = FormatText(dynamicValue);
			SetText(text);
		}

		private void SetText(string text)
		{
			if (!_textComponent) return;

			_textComponent.SetText(text);
		}
	}
}