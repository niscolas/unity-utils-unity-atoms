using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Functions.Impl.Extractors {
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(menuName = AtomsConstants.FunctionsCreateAssetMenuPath + "(int) => Extract : float")]
	public class ExtractFloatFromInt : BaseExtractor<float, int> {
		protected override float Extract(int entry) {
			return entry;
		}
	}
}