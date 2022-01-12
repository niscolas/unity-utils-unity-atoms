using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.ActionsCreateAssetMenuPrefix + "(int) => Set Target FPS",
        order = Constants.CreateAssetMenuOrder)]
    public class SetTargetFPSAtomAction : AtomAction<int>
    {
        [SerializeField]
        private IntReference _fixedTargetFps;

        public override void Do()
        {
            Do(_fixedTargetFps);
        }

        public override void Do(int entry)
        {
            if (Application.targetFrameRate == entry) return;
            Application.targetFrameRate = entry;
        }
    }
}