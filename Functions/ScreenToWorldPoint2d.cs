using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Functions {
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(menuName =
		AtomsConstants.FunctionsCreateAssetMenuPath + "(" + nameof(Vector2) + ") => Screen To World Point")]
	public class ScreenToWorldPoint2d : Vector2Vector2Function {
		private Camera mainCamera;

		public override Vector2 Call(Vector2 parameter) {
			if (mainCamera == null) {
				mainCamera = Camera.main;
			}

			if (mainCamera == null) {
				return Vector2.zero;
			}

			return mainCamera.ScreenToWorldPoint(parameter);
		}
	}
}