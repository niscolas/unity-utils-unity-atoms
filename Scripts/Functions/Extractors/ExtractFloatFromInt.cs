using UnityAtoms;
using UnityEngine;

namespace Plugins.Scripts.Functions.Extractors
{
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(menuName = Constants.FunctionsCreateAssetMenuPath + "(int) => Extract : float")]
	public class ExtractFloatFromInt : BaseExtractor<float, int>
	{
		protected override float Extract(int entry)
		{
			return entry;
		}
	}
}