using UnityAtoms;
using UnityAtoms.SceneMgmt;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = UnityAtomsConstants.SceneManagementCreateAssetMenuPrefix + "Improved Change Scene")]
    public class ImprovedLoadScene : AtomAction
    {
        [FormerlySerializedAs("sceneFieldReference")]
        [SerializeField]
        private SceneFieldReference _scene;

        [FormerlySerializedAs("loadSceneMode")]
        [SerializeField]
        private LoadSceneMode _loadSceneMode;

        public override void Do()
        {
            bool isSceneLoaded = SceneManager.GetSceneByName(_scene.Value.SceneName).isLoaded;

            if (isSceneLoaded)
            {
                return;
            }

            SceneManager.LoadScene(_scene.Value.SceneName, _loadSceneMode);
        }
    }
}