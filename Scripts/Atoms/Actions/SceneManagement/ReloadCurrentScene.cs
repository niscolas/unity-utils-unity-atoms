using niscolas.UnityAtomsUtils;
using niscolas.UnityUtils.UnityAtoms;
using UnityAtoms;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityAtomsUtils.Actions.SceneManagement
{
	[CreateAssetMenu(
		menuName = Constants.SceneManagementCreateAssetMenuPath + "() => Reload Current Scene")]
	public class ReloadCurrentScene : AtomAction
	{
		public override void Do()
		{
			int activeSceneIndex = SceneManager.GetActiveScene().buildIndex;
			SceneManager.LoadScene(activeSceneIndex);
		}
	}
}