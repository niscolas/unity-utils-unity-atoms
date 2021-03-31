using UnityAtoms;
using UnityAtoms.MonoHooks;
using UnityEngine;

namespace Plugins.Scripts.Functions.Extractors
{
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(
		menuName = Constants.FunctionsCreateAssetMenuPath + "(ColliderGameObject) => Extract : Collider")]
	public class ExtractColliderFromColliderGameObject : BaseExtractor<Collider, ColliderGameObject>
	{
		protected override Collider Extract(ColliderGameObject entry)
		{
			return entry.Collider;
		}
	}
}