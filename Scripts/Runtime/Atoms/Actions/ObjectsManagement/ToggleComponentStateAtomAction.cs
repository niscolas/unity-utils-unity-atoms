using UnityAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.ActionsCreateAssetMenuPrefix + "(Behaviour) => Toggle Enabled State",
        order = Constants.CreateAssetMenuOrder)]
    public class ToggleComponentStateAtomAction : AtomAction<Behaviour>
    {
        public override void Do(Behaviour entry)
        {
            if (!entry)
            {
                return;
            }

            entry.enabled = !entry.enabled;
        }
    }
}