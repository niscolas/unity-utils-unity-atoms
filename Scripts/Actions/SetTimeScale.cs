using UnityAtoms;
using UnityEngine;

namespace Plugins.Scripts.Actions
{
	[CreateAssetMenu(
		menuName = Constants.ActionsCreateAssetMenuPath + "(float) => Set Time Scale")]
	public class SetTimeScale : AtomAction<float>
	{
		public override void Do(float timeScale)
		{
			Time.timeScale = timeScale;
		}
	}
}