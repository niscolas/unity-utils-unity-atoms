using niscolas.UnityUtils.Core;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.ActionsCreateAssetMenuPrefix + "(Component) => Despawn",
        order = Constants.CreateAssetMenuOrder)]
    public class DespawnComponentAtomAction : AtomAction<Component>
    {
        [SerializeField]
        private FloatReference _delay;

        [SerializeField]
        private DespawnStrategySO _strategySo;

        public override void Do(Component component)
        {
            _strategySo.Despawn(component, _delay.Value);
        }
    }
}