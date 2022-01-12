using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    public class SavePosition : SaveTransform
    {
        protected override Vector3 GetSaveValue()
        {
            return transform.position;
        }
    }
}