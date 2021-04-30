using System;
using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsMonoBehaviourUtils {
	public class TimerWidgetController : MonoBehaviour {
		[Header("Text")]
		[SerializeField]
		private TMP_Text timeLeftComponent;

		[Header("References")]
		[SerializeField]
		private StringReference timePatternRef;

		public void UpdateText(int timeLeft) {
			TimeSpan timeSpan = TimeSpan.FromSeconds(timeLeft);
			string timeLeftText = timeSpan.ToString(timePatternRef?.Value);
			timeLeftComponent.SetText(timeLeftText);
		}
	}
}