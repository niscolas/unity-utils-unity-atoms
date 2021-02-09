using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Functions.Impl.Extractors {
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(menuName = AtomsConstants.FunctionsCreateAssetMenuPath + "(int) => Extract : float")]
	public class ExtractFloatFromInt : FloatIntFunction {
		public override float Call(int entry) {
			return entry;
		}
	}
}