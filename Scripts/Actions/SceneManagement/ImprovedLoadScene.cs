﻿using UnityAtoms;
using UnityAtoms.SceneMgmt;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Plugins.Scripts.Actions.SceneManagement
{
	[EditorIcon("atom-icon-purple")]
	[CreateAssetMenu(
		menuName = Constants.SceneManagementCreateAssetMenuPath + "Improved Change Scene")]
	public class ImprovedLoadScene : AtomAction
	{
		[SerializeField]
		private SceneFieldReference sceneFieldReference;

		[SerializeField]
		private LoadSceneMode loadSceneMode;

		public override void Do()
		{
			SceneManager.LoadScene(sceneFieldReference.Value.BuildIndex, loadSceneMode);
		}
	}
}