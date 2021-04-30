using UnityAtoms;
using UnityAtoms.MonoHooks;

namespace UnityAtomsUtils.Hooks
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