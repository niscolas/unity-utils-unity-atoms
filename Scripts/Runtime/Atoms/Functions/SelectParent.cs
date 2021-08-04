using niscolas.UnityAtomsUtils;
using UnityAtoms;
using UnityAtoms.MonoHooks;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(
		menuName = Constants.FunctionsCreateAssetMenuPath + "(GameObject) => Select Parent : GameObject")]
	public class SelectParent : GameObjectGameObjectFunction
	{
		public override GameObject Call(GameObject entry)
		{
			return entry.transform.parent.gameObject;
		}
	}
}