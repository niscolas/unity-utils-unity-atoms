using System.Linq;
using niscolas.UnityAtomsUtils;
using Sirenix.OdinInspector;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(
		menuName = UnityAtomsConstants.FunctionsCreateAssetMenuPrefix + "(GameObject) => Select With Tag : GameObject")]
	public class SelectWithTag : GameObjectGameObjectFunction
	{
		[SerializeField]
		private StringConstant tag;

		[SerializeField]
		private bool _selectFromRoot;

		[HideIf(nameof(_selectFromRoot))]
		[SerializeField]
		private bool searchInParents = true;

		[HideIf(nameof(_selectFromRoot))]
		[SerializeField]
		private bool searchInChildren = true;

		public override GameObject Call(GameObject entry)
		{
			if (!entry || !tag) return default;

			GameObject result;

			if (_selectFromRoot)
			{
				result = entry
					.FindWithTagFromRoot(tag.Value)
					.FirstOrDefault();
			}
			else
			{
				result = entry
					.FindWithTagInHierarchy(tag.Value, searchInParents, searchInChildren)
					.FirstOrDefault();
			}

			return result;
		}
	}
}