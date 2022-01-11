using UnityAtoms.SceneMgmt;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.ConditionsCreateAssetMenuPrefix + "() => Is Current Scene?",
        order = Constants.CreateAssetMenuOrder)]
    public class IsCurrentSceneAtomCondition : VoidAtomCondition
    {
        [SerializeField]
        private SceneFieldReference _testScene;

        public override bool Call()
        {
            return _testScene.Value.ScenePath == SceneManager.GetActiveScene().path;
        }
    }
}