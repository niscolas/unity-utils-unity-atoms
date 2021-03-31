using UnityAtoms;
using UnityEngine;

namespace Plugins.Scripts.Functions.Extractors
{
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(menuName = Constants.FunctionsCreateAssetMenuPath + "(float) => Extract : int")]
	public class ExtractIntFromFloat : BaseExtractor<int, float>
	{
		protected override int Extract(float entry)
		{
			return (int) entry;
		}
	}
}