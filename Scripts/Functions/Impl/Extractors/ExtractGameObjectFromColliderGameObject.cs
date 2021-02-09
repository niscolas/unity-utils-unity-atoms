using UnityAtoms;
using UnityAtoms.MonoHooks;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Functions.Impl.Extractors {
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(
		menuName = AtomsConstants.FunctionsCreateAssetMenuPath + "(ColliderGameObject) => Extract : GameObject")]
	public class ExtractGameObjectFromColliderGameObject : GameObjectColliderGameObjectFunction {
		public override GameObject Call(ColliderGameObject entry) {
			return entry.GameObject;
		}
	}
}