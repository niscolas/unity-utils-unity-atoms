using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.ActionsCreateAssetMenuPrefix + "(int) => Set VSync Count",
        order = Constants.CreateAssetMenuOrder)]
    public class SetVSyncCountAtomAction : AtomAction<int>
    {
        [SerializeField]
        private IntReference _fixedValue;

        public override void Do(int value)
        {
            QualitySettings.vSyncCount = value;
        }

        public override void Do()
        {
            Do(_fixedValue);
        }
    }
}