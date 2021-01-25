using UnityAtoms;
using UnityEditor;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Actions {
	[CreateAssetMenu(menuName = AtomsConstants.ActionsCreateAssetMenuPath + "() => Unload Unused Assets")]
	public class UnloadUnusedAssets : AtomAction<Void> {
		public override void Do(Void t1) {
			Do();
		}

		public override void Do() {
#if UNITY_EDITOR
			EditorUtility.UnloadUnusedAssetsImmediate();
#endif
		}
	}
}