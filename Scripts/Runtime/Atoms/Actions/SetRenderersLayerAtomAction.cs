using niscolas.UnityUtils.Core.Extensions;
using niscolas.UnityUtils.UnityAtoms;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = UnityAtoms.Constants.ActionsCreateAssetMenuPrefix + "(GameObject) => Set Renderers Layer")]
    public class SetRenderersLayerAtomAction : AtomAction<GameObject>
    {
        [SerializeField]
        private StringReference _layerName;

        public override void Do(GameObject gameObject)
        {
            int layer = LayerMask.NameToLayer(_layerName.Value);

            gameObject
                .GetComponentsInChildren<Renderer>()
                .GetGameObjects()
                .ForEach(r => r.layer = layer);
        }
    }
}