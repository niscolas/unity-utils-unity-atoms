using UnityAtoms;
using UnityAtoms.MonoHooks;

namespace Plugins.UnityAtomsUtils.Scripts.Hooks {
	[EditorIcon("atom-icon-delicate")]
	public class OnMouseDownHook : VoidHook {
		private void OnMouseDown() {
			OnHook();
		}
	}
}