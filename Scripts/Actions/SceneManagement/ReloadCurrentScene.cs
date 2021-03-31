using UnityAtoms;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Plugins.Scripts.Actions.SceneManagement
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