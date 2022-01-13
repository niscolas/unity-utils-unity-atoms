using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [AddComponentMenu(Constants.AddComponentMenuPrefix + "Save Position")]
    public class SavePositionMB : SaveTransformMB
    {
        protected override Vector3 GetSaveValue()
        {
            return _transform.position;
        }
    }
}