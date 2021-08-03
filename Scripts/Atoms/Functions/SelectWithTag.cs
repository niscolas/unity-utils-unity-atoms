using System.Linq;
using niscolas.UnityAtomsUtils;
using niscolas.UnityUtils.UnityAtoms;
using Sirenix.OdinInspector;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityAtomsUtils.Extensions;
using UnityEngine;

namespace UnityAtomsUtils.Functions
{
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(
		menuName = Constants.FunctionsCreateAssetMenuPath + "(GameObject) => Select With Tag : GameObject")]
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