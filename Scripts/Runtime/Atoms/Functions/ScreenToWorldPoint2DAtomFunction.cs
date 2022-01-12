using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(menuName =
        Constants.FunctionsCreateAssetMenuPrefix + "(Vector2) => Screen To World Point")]
    public class ScreenToWorldPoint2DAtomFunction : Vector2Vector2Function
    {
        private Camera mainCamera;

        public override Vector2 Call(Vector2 parameter)
        {
            if (mainCamera == null)
            {
                mainCamera = Camera.main;
            }

            if (mainCamera == null)
            {
                return Vector2.zero;
            }

            return mainCamera.ScreenToWorldPoint(parameter);
        }
    }
}