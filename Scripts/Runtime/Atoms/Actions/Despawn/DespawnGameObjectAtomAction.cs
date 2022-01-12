using niscolas.UnityUtils.Core;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.ActionsCreateAssetMenuPrefix + "(GameObject) => Despawn",
        order = Constants.CreateAssetMenuOrder)]
    public class DespawnGameObjectAtomAction : AtomAction<GameObject>
    {
        [SerializeField]
        private FloatReference _delay;

        [SerializeField]
        private DespawnStrategySO _strategySo;

        public override void Do(GameObject gameObject)
        {
            _strategySo.Despawn(gameObject, _delay.Value);
        }
    }
}