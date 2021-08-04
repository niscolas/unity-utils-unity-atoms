using UnityAtoms.MonoHooks;

namespace niscolas.UnityUtils.UnityAtoms
{
	public class OnEnableHook : VoidHook
	{
		private void OnEnable()
		{
			OnHook();
		}
	}
}