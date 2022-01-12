using UnityAtoms;
using UnityAtoms.SceneMgmt;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.SceneManagementCreateAssetMenuPrefix + "Improved Change Scene",
        order = Constants.CreateAssetMenuOrder)]
    public class ImprovedLoadSceneAtomAction : AtomAction
    {
        [SerializeField]
        private SceneFieldReference _scene;

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