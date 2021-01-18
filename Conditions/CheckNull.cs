using NaughtyAttributes;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Conditions {
	[EditorIcon("atom-icon-teal")]
	[CreateAssetMenu(menuName = AtomsConstants.ConditionsCreateAssetMenuPath + "Check Null")]
	public class CheckNull : AtomCondition<UnityEngine.GameObject> {
		[SerializeField]
		private bool checkIfIsNotNull;

		[SerializeField]
		private bool useVariable;

		[ShowIf(nameof(useVariable))]
		[SerializeField]
		private AtomBaseVariable variable;

		public override bool Call(UnityEngine.GameObject target) {
			bool result = useVariable ? variable.BaseValue == null : target == null;
			return checkIfIsNotNull ? !result : result;
		}
	}
}