using niscolas.UnityAtomsUtils;
using UnityAtoms;
using UnityAtoms.SceneMgmt;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

namespace UnityAtomsUtils.Actions.SceneManagement
{
	[EditorIcon("atom-icon-purple")]
	[CreateAssetMenu(
		menuName = Constants.SceneManagementCreateAssetMenuPath + "Improved Change Scene")]
	public class ImprovedLoadScene : AtomAction
	{
		[FormerlySerializedAs("sceneFieldReference"), SerializeField]
		private SceneFieldReference _scene;

		[FormerlySerializedAs("loadSceneMode"), SerializeField]
		private LoadSceneMode _loadSceneMode;

		public override void Do()
		{
			bool isSceneLoaded = SceneManager.GetSceneByBuildIndex(_scene.Value.BuildIndex).isLoaded;

			if (isSceneLoaded) return;

			SceneManager.LoadScene(_scene.Value.BuildIndex, _loadSceneMode);
		}
	}
}