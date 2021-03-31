using UnityAtoms;
using UnityAtoms.MonoHooks;

namespace Plugins.Scripts.Hooks
{
	[EditorIcon("atom-icon-delicate")]
	public class OnMouseDownHook : VoidHook
	{
		private void OnMouseDown()
		{
			OnHook();
		}
	}
}