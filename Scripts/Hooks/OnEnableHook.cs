using UnityAtoms;
using UnityAtoms.MonoHooks;

namespace Plugins.Scripts.Hooks
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