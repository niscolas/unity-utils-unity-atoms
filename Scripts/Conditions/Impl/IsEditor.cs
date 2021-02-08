using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Conditions.Impl {
	[EditorIcon("atom-icon-teal")]
	[CreateAssetMenu(menuName = AtomsConstants.ConditionsCreateAssetMenuPath + "() => Is Editor?")]
	public class IsEditor : VoidCondition {
		[SerializeField]
		private bool invert;

		public override bool Call() {
			return invert ? !Application.isEditor : Application.isEditor;
		}
	}
}