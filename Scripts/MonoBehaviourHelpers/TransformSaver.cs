using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.Scripts.MonoBehaviourHelpers
{
	public class TransformSaver : MonoBehaviour
	{
		[SerializeField]
		private Vector3Variable positionVar;

		[SerializeField]
		private QuaternionVariable rotationVar;

		[SerializeField]
		private Vector3Variable scaleVar;

		[ContextMenu(nameof(SaveAll))]
		private void SaveAll()
		{
			SavePosition();
			SaveRotation();
			SaveScale();
		}

		[ContextMenu(nameof(SavePosition))]
		private void SavePosition()
		{
			if (!positionVar)
			{
				return;
			}

			positionVar.Value = transform.position;
		}

		[ContextMenu(nameof(SaveRotation))]
		private void SaveRotation()
		{
			if (!rotationVar)
			{
				return;
			}

			rotationVar.Value = transform.rotation;
		}

		[ContextMenu(nameof(SaveScale))]
		private void SaveScale()
		{
			if (!scaleVar)
			{
				return;
			}

			scaleVar.Value = transform.localScale;
		}
	}
}