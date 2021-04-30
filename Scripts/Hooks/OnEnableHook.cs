using UnityAtoms;
using UnityAtoms.MonoHooks;

namespace UnityAtomsUtils.Hooks
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