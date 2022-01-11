using UnityAtoms;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = UnityAtomsConstants.SceneManagementCreateAssetMenuPrefix + "() => Reload Current Scene")]
    public class ReloadCurrentScene : AtomAction
    {
        public override void Do()
        {
            int activeSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(activeSceneIndex);
        }
    }
}