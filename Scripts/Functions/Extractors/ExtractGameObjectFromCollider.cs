using UnityAtoms;
using UnityEngine;

namespace Plugins.Scripts.Functions.Extractors
{
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(menuName = Constants.FunctionsCreateAssetMenuPath + "(Collider) => Extract : GameObject")]
	public class ExtractGameObjectFromCollider : BaseExtractor<GameObject, Collider>
	{
		protected override GameObject Extract(Collider entry)
		{
			return entry.gameObject;
		}
	}
}