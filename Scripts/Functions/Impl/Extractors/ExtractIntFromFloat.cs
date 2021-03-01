using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Functions.Impl.Extractors {
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(menuName = AtomsConstants.FunctionsCreateAssetMenuPath + "(float) => Extract : int")]
	public class ExtractIntFromFloat : BaseExtractor<int, float> {
		protected override int Extract(float entry) {
			return (int) entry;
		}
	}
}