using System.Linq;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityAtomsUtils.Extensions;
using UnityEngine;
using UnityEngine.Serialization;

namespace UnityAtomsUtils.Conditions
{
	[CreateAssetMenu(
		menuName = Constants.ConditionsCreateAssetMenuPath + "(GameObject) => Has Tag?")]
	public class HasTag : AtomCondition<GameObject>
	{
		[FormerlySerializedAs("mustHaveTag")]
		[SerializeField]
		private StringConstant tag;

		[SerializeField]
		private bool searchInParents = true;

		[SerializeField]
		private bool searchInChildren = true;

		public override bool Call(GameObject entry)
		{
			return entry.FindWithTagInHierarchy(tag.Value, searchInParents, searchInChildren).Any();
		}
	}
}