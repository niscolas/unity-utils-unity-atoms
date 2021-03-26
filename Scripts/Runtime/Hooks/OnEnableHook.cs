using UnityAtoms;
using UnityAtoms.MonoHooks;

namespace Plugins.UnityAtomsUtils.Scripts.Runtime.Hooks
{
	[EditorIcon("atom-icon-delicate")]
	public class OnEnableHook : VoidHook
	{
		private void OnEnable()
		{
			OnHook();
		}
	}
}