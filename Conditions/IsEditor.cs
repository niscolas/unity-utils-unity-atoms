using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Conditions {
	[EditorIcon("atom-icon-teal")]
	[CreateAssetMenu(menuName = AtomsConstants.ConditionsCreateAssetMenuPath + "() => Is Editor")]
	public class IsEditor : VoidCondition {
		[SerializeField]
		private bool checkIfIsNotEditor;

		public override bool Call() {
			return checkIfIsNotEditor ? !Application.isEditor : Application.isEditor;
		}
	}
}