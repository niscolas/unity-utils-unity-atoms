using niscolas.UnityUtils.Core;
using niscolas.UnityUtils.UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = UnityAtoms.Constants.FunctionsCreateAssetMenuPrefix + "(GameObject) => Select Root : GameObject")]
    public class SelectRootAtomFunction : GameObjectGameObjectFunction
    {
        public override GameObject Call(GameObject gameObject)
        {
            return gameObject.Root();
        }
    }
}