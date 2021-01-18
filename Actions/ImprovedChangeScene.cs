using UnityAtoms;
using UnityAtoms.SceneMgmt;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Plugins.UnityAtomsUtils.Actions {
	[EditorIcon("atom-icon-purple")]
	[CreateAssetMenu(menuName = AtomsConstants.ActionsCreateAssetMenuPath + "Scene Management/Better Change Scene")]
	public class ImprovedChangeScene : AtomAction {
		[SerializeField]
		private SceneFieldReference sceneFieldReference;

		[SerializeField]
		private LoadSceneMode loadSceneMode;

		public override void Do() {
			SceneManager.LoadScene(sceneFieldReference.Value.BuildIndex, loadSceneMode);
		}
	}
}