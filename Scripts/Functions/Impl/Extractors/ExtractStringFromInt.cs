using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Functions.Impl.Extractors {
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(menuName = AtomsConstants.FunctionsCreateAssetMenuPath + "(int) => Extract : string")]
	public class ExtractStringFromInt : BaseExtract<string, int> {
		protected override string Extract(int entry) {
			return entry.ToString();
		}
	}
}