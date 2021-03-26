using System;
using TMPro;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Runtime.MonoBehaviourHelpers.UiBinders
{
	public abstract class BaseBindText<T, P, C, V, E1, E2, EI, ER, F, VI, R> : MonoBehaviour
		where R : AtomReference<T, P, C, V, E1, E2, F, VI>
		where P : struct, IPair<T>
		where C : AtomBaseVariable<T>
		where V : AtomVariable<T, P, E1, E2, F>
		where E1 : AtomEvent<T>
		where E2 : AtomEvent<P>
		where EI : AtomEventInstancer<T, E1>
		where ER : AtomEventReference<T, V, E1, VI, EI>
		where F : AtomFunction<T, T>
		where VI : AtomVariableInstancer<V, P, T, E1, E2, F>
	{
		[SerializeField]
		private TMP_Text _textComponent;

		[SerializeField]
		private V _variable;

		protected abstract string GetFormattedText(T value);

		private void Awake()
		{
			RegisterToDynamicEvent();
		}

		private void OnEnable()
		{
			UpdateText();
		}

		private void RegisterToDynamicEvent()
		{
			if (!_variable) return;

			E1 varEvent = _variable.GetOrCreateEvent<E1>();
			varEvent.Register(UpdateText);
		}

		public void UpdateText(T dynamicValue)
		{
			string text = GetFormattedText(dynamicValue);
			SetText(text);
		}

		public void UpdateText()
		{
			if (!_variable) return;

			UpdateText(_variable.Value);
		}

		private void SetText(string text)
		{
			if (!_textComponent) return;

			_textComponent.SetText(text);
		}
	}
}