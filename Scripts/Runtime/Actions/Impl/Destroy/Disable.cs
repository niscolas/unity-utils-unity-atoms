using System;
using Cysharp.Threading.Tasks;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Actions.Impl.Destroy {
	[CreateAssetMenu(
		menuName = AtomsConstants.ActionsCreateAssetMenuPath +
		           "(GameObject) => Disable")]
	public class Disable : AtomAction<GameObject> {
		[SerializeField]
		private FloatReference delay;

		public override async void Do(GameObject entryValue) {
			await UniTask.Delay(TimeSpan.FromSeconds(delay.Value));
			entryValue.SetActive(false);
		}
	}
}