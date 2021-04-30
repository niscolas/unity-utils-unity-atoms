using TMPro;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtomsUtils.MonoBehaviourHelpers
{
	public class RichTextUpdater : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text textComponent;

		[Header("References")]
		[SerializeField]
		private StringReference baseTextBeforeDynamicValue;

		[SerializeField]
		private StringReference baseTextAfterDynamicValue;

		private void Awake()
		{
			if (!textComponent)
			{
				textComponent = GetComponentInChildren<TMP_Text>();
			}
		}

		public void UpdateText(string newText)
		{
			string text = baseTextBeforeDynamicValue + newText + baseTextAfterDynamicValue;
			textComponent.SetText(text);
		}
	}
}