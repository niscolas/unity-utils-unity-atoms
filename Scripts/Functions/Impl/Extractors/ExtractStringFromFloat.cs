using System.Globalization;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Functions.Impl.Extractors {
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(menuName = AtomsConstants.FunctionsCreateAssetMenuPath + "(float) => Extract : string")]
	public class ExtractStringFromFloat : StringFloatFunction {
		public override string Call(float entry) {
			return entry.ToString(CultureInfo.InvariantCulture);
		}
	}
}