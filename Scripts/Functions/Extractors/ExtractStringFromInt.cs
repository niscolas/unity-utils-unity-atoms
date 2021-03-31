using UnityAtoms;
using UnityEngine;

namespace Plugins.Scripts.Functions.Extractors
{
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(menuName = Constants.FunctionsCreateAssetMenuPath + "(int) => Extract : string")]
	public class ExtractStringFromInt : BaseExtractor<string, int>
	{
		protected override string Extract(int entry)
		{
			return entry.ToString();
		}
	}
}