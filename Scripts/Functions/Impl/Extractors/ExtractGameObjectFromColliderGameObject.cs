using UnityAtoms;
using UnityAtoms.MonoHooks;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Functions.Impl.Extractors {
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(
		menuName = AtomsConstants.FunctionsCreateAssetMenuPath + "(ColliderGameObject) => Extract : GameObject")]
	public class ExtractGameObjectFromColliderGameObject : BaseExtractor<GameObject, ColliderGameObject> {
		protected override GameObject Extract(ColliderGameObject entry) {
			return entry.GameObject;
		}
	}
}