using System.Linq;
using Plugins.UnityAtomsUtils.Scripts.Runtime.ClassExtensions;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Serialization;

namespace Plugins.UnityAtomsUtils.Scripts.Conditions.Impl {
	[CreateAssetMenu(
		menuName = AtomsConstants.ConditionsCreateAssetMenuPath + "(GameObject) => Has Tag?")]
	public class HasTag : AtomCondition<GameObject> {
		[FormerlySerializedAs("mustHaveTag")]
		[SerializeField]
		private StringConstant tag;

		[SerializeField]
		private bool searchInParents = true;

		[SerializeField]
		private bool searchInChildren = true;

		public override bool Call(GameObject entry) {
			return entry.FindWithTagInHierarchy(tag.Value, searchInParents, searchInChildren).Any();
		}
	}
}