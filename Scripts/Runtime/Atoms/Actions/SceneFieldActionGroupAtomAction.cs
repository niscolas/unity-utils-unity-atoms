using niscolas.UnityUtils.UnityAtoms;
using UnityAtoms.SceneMgmt;
using UnityEngine;

namespace niscolas.UnityUtils.Extras
{
    [CreateAssetMenu(
        menuName = Constants.ActionsCreateAssetMenuPrefix + "(SceneField) => Scene Field Action Group")]
    public class SceneFieldActionGroupAtomAction : ActionGroupAtomAction<
        SceneField,
        SceneFieldPair,
        SceneFieldConstant,
        SceneFieldVariable,
        SceneFieldEvent,
        SceneFieldPairEvent,
        SceneFieldSceneFieldFunction,
        SceneFieldVariableInstancer,
        SceneFieldReference> { }
}