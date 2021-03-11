using TMPro;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Runtime.MonoBehaviourHelpers.UiBinders {
	public abstract class BaseUpdateText<T, P, C, V, E1, E2, F, VI, R> : MonoBehaviour
		where R : AtomReference<T, P, C, V, E1, E2, F, VI>
		where P : struct, IPair<T>
		where C : AtomBaseVariable<T>
		where V : AtomVariable<T, P, E1, E2, F>
		where E1 : AtomEvent<T>
		where E2 : AtomEvent<P>
		where F : AtomFunction<T, T>
		where VI : AtomVariableInstancer<V, P, T, E1, E2, F> {
		[SerializeField]
		private R fixedValue;

		[SerializeField]
		private TMP_Text textComponent;

		protected abstract string GetFormattedText(T value);

		public void UpdateText(T dynamicValue) {
			string text = GetFormattedText(dynamicValue);
			SetText(text);
		}

		public void UpdateText() {
			if (fixedValue == null) {
				return;
			}

			UpdateText(fixedValue.Value);
		}

		private void SetText(string text) {
			if (!textComponent) {
				return;
			}

			textComponent.SetText(text);
		}
	}
}