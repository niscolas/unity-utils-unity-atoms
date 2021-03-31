using UnityAtoms;
using UnityAtoms.MonoHooks;
using UnityEngine;

namespace Plugins.Scripts.Functions.Extractors
{
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(
		menuName = Constants.FunctionsCreateAssetMenuPath + "(ColliderGameObject) => Extract : GameObject")]
	public class ExtractGameObjectFromColliderGameObject : BaseExtractor<GameObject, ColliderGameObject>
	{
		protected override GameObject Extract(ColliderGameObject entry)
		{
			return entry.GameObject;
		}
	}
}