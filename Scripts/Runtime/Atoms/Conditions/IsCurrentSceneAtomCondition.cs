using UnityAtoms.SceneMgmt;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = UnityAtomsConstants.ConditionsCreateAssetMenuPrefix + "() => Is Current Scene?")]
    public class IsCurrentSceneAtomCondition : VoidCondition
    {
        [SerializeField]
        private SceneFieldReference _testScene;
        
        public override bool Call()
        {
            return _testScene.Value.ScenePath == SceneManager.GetActiveScene().path;
        }
    }
}