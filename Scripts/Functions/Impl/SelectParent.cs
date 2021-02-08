using UnityAtoms;
using UnityAtoms.MonoHooks;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Functions.Impl {
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(
		menuName = AtomsConstants.FunctionsCreateAssetMenuPath + "(GameObject) => Select Parent : GameObject")]
	public class SelectParent : GameObjectGameObjectFunction {
		public override GameObject Call(GameObject entry) {
			return entry.transform.parent.gameObject;
		}
	}
}