using UnityAtoms;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.SceneManagementCreateAssetMenuPrefix + "() => Reload Current Scene",
        order = Constants.CreateAssetMenuOrder)]
    public class ReloadCurrentSceneAtomAction : AtomAction
    {
        public override void Do()
        {
            int activeSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(activeSceneIndex);
        }
    }
}