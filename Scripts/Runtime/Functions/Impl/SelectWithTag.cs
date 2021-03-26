using System.Linq;
using Plugins.UnityAtomsUtils.Scripts.Runtime.ClassExtensions;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using GameObjectGameObjectFunction = UnityAtoms.MonoHooks.GameObjectGameObjectFunction;

namespace Plugins.UnityAtomsUtils.Scripts.Functions.Impl {
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(
		menuName = AtomsConstants.FunctionsCreateAssetMenuPath + "(GameObject) => Select With Tag : GameObject")]
	public class SelectWithTag : GameObjectGameObjectFunction {
		[SerializeField]
		private StringConstant tag;

		[SerializeField]
		private bool searchInParents = true;

		[SerializeField]
		private bool searchInChildren = true;

		public override GameObject Call(GameObject entry) {
			return !entry 
				? null 
				: entry.FindWithTagInHierarchy(tag.Value, searchInParents, searchInChildren).FirstOrDefault();
		}
	}
}