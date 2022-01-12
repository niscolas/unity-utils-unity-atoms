using UnityAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.ActionsCreateAssetMenuPrefix + "(GameObject) => Toggle Active State",
        order = Constants.CreateAssetMenuOrder)]
    public class ToggleGameObjectStateAtomAction : AtomAction<GameObject>
    {
        public override void Do(GameObject entry)
        {
            if (!entry)
            {
                return;
            }

            entry.SetActive(!entry.activeSelf);
        }
    }
}