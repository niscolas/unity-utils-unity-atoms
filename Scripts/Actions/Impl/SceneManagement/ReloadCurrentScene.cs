using UnityAtoms;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Plugins.UnityAtomsUtils.Scripts.Actions.Impl.SceneManagement {
	[CreateAssetMenu(
		menuName = AtomsConstants.SceneManagementCreateAssetMenuPath + "() => Reload Current Scene")]
	public class ReloadCurrentScene : AtomAction{
		public override void Do() {
			int activeSceneIndex = SceneManager.GetActiveScene().buildIndex;
			SceneManager.LoadScene(activeSceneIndex);
		}
	}
}