using System.Linq;
using Plugins.Scripts.ClassExtensions;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using GameObjectGameObjectFunction = UnityAtoms.MonoHooks.GameObjectGameObjectFunction;

namespace Plugins.Scripts.Functions
{
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(
		menuName = Constants.FunctionsCreateAssetMenuPath + "(GameObject) => Select With Tag : GameObject")]
	public class SelectWithTag : GameObjectGameObjectFunction
	{
		[SerializeField]
		private StringConstant tag;

		[SerializeField]
		private bool searchInParents = true;

		[SerializeField]
		private bool searchInChildren = true;

		public override GameObject Call(GameObject entry)
		{
			return !entry
				? null
				: entry.FindWithTagInHierarchy(tag.Value, searchInParents, searchInChildren).FirstOrDefault();
		}
	}
}