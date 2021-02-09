using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Functions.Impl.Extractors {
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(menuName = AtomsConstants.FunctionsCreateAssetMenuPath + "(Collider) => Extract : GameObject")]
	public class ExtractGameObjectFromCollider : GameObjectColliderFunction {
		public override GameObject Call(Collider entry) {
			return entry.gameObject;
		}
	}
}