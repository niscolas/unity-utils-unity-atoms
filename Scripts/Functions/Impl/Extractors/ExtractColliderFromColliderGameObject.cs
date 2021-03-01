using UnityAtoms;
using UnityAtoms.MonoHooks;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Functions.Impl.Extractors {
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(
		menuName = AtomsConstants.FunctionsCreateAssetMenuPath + "(ColliderGameObject) => Extract : Collider")]
	public class ExtractColliderFromColliderGameObject : BaseExtractor<Collider, ColliderGameObject> {
		protected override Collider Extract(ColliderGameObject entry) {
			return entry.Collider;
		}
	}
}