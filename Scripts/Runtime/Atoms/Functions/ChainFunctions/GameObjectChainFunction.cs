using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(menuName =
        UnityAtomsConstants.FunctionsCreateAssetMenuPrefix + "(GameObject) => Chain Function : GameObject")]
    public class GameObjectChainFunction : BaseChainFunction<GameObject> { }
}