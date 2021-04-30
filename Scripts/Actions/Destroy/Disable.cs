using System;
using Cysharp.Threading.Tasks;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtomsUtils.Actions.Destroy
{
	[CreateAssetMenu(
		menuName = Constants.ActionsCreateAssetMenuPath +
		           "(GameObject) => Disable")]
	public class Disable : AtomAction<GameObject>
	{
		[SerializeField]
		private FloatReference delay;

		public override async void Do(GameObject entryValue)
		{
			await UniTask.Delay(TimeSpan.FromSeconds(delay.Value));
			entryValue.SetActive(false);
		}
	}
}