using Sirenix.OdinInspector;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtomsUtils.MonoBehaviourHelpers.TransformUtils
{
	public class BoundsBehaviour : MonoBehaviour
	{
		[SerializeField]
		private Transform _center;

		[SerializeField]
		private Vector3Reference _size;

		[Title("Visualization")]
		[ColorUsage(true, true)]
		[SerializeField]
		private Color _gizmosColor = Color.blue;

		[SerializeField]
		private bool _drawAlways;

		public Transform Center
		{
			get => _center;
			set => _center = value;
		}

		public Vector3Reference Size => _size;

		public Bounds Bounds { get; private set; }

		private void Awake()
		{
			UpdateBounds();
		}

		public void UpdateBounds()
		{
			if (!_center) return;

			Vector3 centerPosition = _center.position;
			Vector3 sizeValue = _size.Value;
			Bounds = new Bounds(centerPosition, sizeValue);
		}

		private void OnDrawGizmos()
		{
			if (!_drawAlways) return;
			Draw();
		}

		private void OnDrawGizmosSelected()
		{
			if (_drawAlways) return;
			Draw();
		}

		private void Draw()
		{
			if (!_center)
			{
				_center = transform;
			}

			Vector3 centerPosition = _center.position;
			Vector3 sizeValue = _size.Value;

			Gizmos.color = _gizmosColor;
			Gizmos.DrawWireCube(centerPosition, sizeValue);
		}
	}
}