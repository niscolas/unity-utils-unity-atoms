using NaughtyAttributes;
using UnityAtoms.BaseAtoms;
using UnityAtoms.Tags;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Actions {
	[CreateAssetMenu(
		menuName = AtomsConstants.ActionsCreateAssetMenuPath + "(GameObject) => Instantiate",
		order = AtomsConstants.CreateAssetMenuOrder)]
	public class Instantiate : GameObjectAction {
		[SerializeField]
		private bool useFixedPrefab;

		[ShowIf(nameof(useFixedPrefab))]
		[SerializeField]
		private GameObjectReference fixedPrefabRef;

		[Header("Parent")]
		[SerializeField]
		private bool hasParent;

		[ShowIf(nameof(hasParent))]
		[SerializeField]
		private bool dontUsePositionAndRotation;

		[ShowIf(nameof(hasParent))]
		[SerializeField]
		private StringConstant parentTag;

		[ShowIf(nameof(hasParent))]
		[SerializeField]
		private bool instantiateInWorldSpace;

		[Header("Position and Rotation")]
		[HideIf(nameof(dontUsePositionAndRotation))]
		[SerializeField]
		private Vector3Reference positionRef;

		[HideIf(nameof(dontUsePositionAndRotation))]
		[SerializeField]
		private QuaternionReference rotationRef;

		public override void Do(UnityEngine.GameObject prefab) {
			DoInstantiate(prefab);
		}

		public override void Do() {
			DoInstantiate(fixedPrefabRef.Value);
		}

		private void DoInstantiate(UnityEngine.GameObject prefab) {
			Transform parent = null;
			if (hasParent) {
				UnityEngine.GameObject parentGameObject = AtomTags.FindByTag(parentTag.Value);
				if (!parentGameObject) {
					parent = parentGameObject.transform;
				}
			}

			UnityEngine.GameObject instance = Instantiate(prefab, parent, instantiateInWorldSpace);
			if (!dontUsePositionAndRotation) {
				instance.transform.position = positionRef.Value;
				instance.transform.rotation = rotationRef.Value;
			}
		}
	}
}