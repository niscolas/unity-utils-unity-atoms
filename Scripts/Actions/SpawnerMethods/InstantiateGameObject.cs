using Lean.Pool;
using Sirenix.OdinInspector;
using UnityAtoms.BaseAtoms;
using UnityAtoms.Tags;
using UnityAtomsUtils;
using UnityEngine;
using UnityEngine.Serialization;

namespace Plugins.UnityAtomsUtils.Scripts.Actions.SpawnerMethods
{
	[CreateAssetMenu(
		menuName = Constants.ActionsCreateAssetMenuPath + "(GameObject) => Instantiate",
		order = Constants.CreateAssetMenuOrder)]
	public class InstantiateGameObject : GameObjectGameObjectFunction
	{
		[FormerlySerializedAs("fixedPrefabRef")]
		[SerializeField]
		private GameObjectReference prefabRef;

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
		private Vector3Reference offsetRef;

		[HideIf(nameof(dontUsePositionAndRotation))]
		[SerializeField]
		private QuaternionReference rotationRef;

		public override GameObject Call(GameObject gameObjectPositionReference)
		{
			return DoInstantiate(gameObjectPositionReference.transform.position);
		}

		public GameObject Call()
		{
			return DoInstantiate();
		}

		public void DoCall(GameObject gameObjectPositionReference)
		{
			Call(gameObjectPositionReference);
		}

		public void DoCall()
		{
			Call();
		}

		private GameObject DoInstantiate(Vector3? position = null)
		{
			Transform parent = null;
			if (hasParent)
			{
				GameObject parentGameObject = AtomTags.FindByTag(parentTag.Value);
				if (parentGameObject)
				{
					parent = parentGameObject.transform;
				}
			}

			GameObject instance = LeanPool.Spawn(prefabRef.Value, parent, instantiateInWorldSpace);

			Vector3 finalPosition = Vector3.zero;
			Quaternion finalRotation = Quaternion.identity;

			if (!dontUsePositionAndRotation)
			{
				finalPosition = positionRef.Value;
				finalRotation = rotationRef.Value;

				if (position != null)
				{
					finalPosition = position.Value;
				}
			}

			instance.transform.position = finalPosition + offsetRef.Value;
			instance.transform.rotation = finalRotation;

			return instance;
		}
	}
}