using UnityAtoms;
using UnityEngine;

namespace UnityAtomsUtils.Actions
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