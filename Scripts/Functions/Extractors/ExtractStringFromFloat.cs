using System.Globalization;
using UnityAtoms;
using UnityEngine;

namespace Plugins.Scripts.Functions.Extractors
{
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(menuName = Constants.FunctionsCreateAssetMenuPath + "(float) => Extract : string")]
	public class ExtractStringFromFloat : BaseExtractor<string, float>
	{
		protected override string Extract(float entry)
		{
			return entry.ToString(CultureInfo.InvariantCulture);
		}
	}
}