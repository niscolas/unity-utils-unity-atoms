using niscolas.UnityAtomsUtils;
using niscolas.UnityUtils.UnityAtoms;
using UnityAtoms;
using UnityAtoms.MonoHooks;
using UnityEngine;

namespace UnityAtomsUtils.Functions
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