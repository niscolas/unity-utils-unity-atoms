using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(menuName = Constants.ActionsCreateAssetMenuPrefix + "(float) => Set Time Scale")]
    public class SetTimeScale : AtomAction<float>
    {
        [SerializeField]
        private FloatReference _fixedValue;

        public override void Do(float timeScale)
        {
            Time.timeScale = timeScale;
        }

        public override void Do()
        {
            Do(_fixedValue);
        }
    }
}