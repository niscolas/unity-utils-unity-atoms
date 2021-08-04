using niscolas.UnityAtomsUtils;
using UnityAtoms;
using UnityAtoms.MonoHooks;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(
		menuName = Constants.FunctionsCreateAssetMenuPath + "(GameObject) => Select Child : GameObject")]
	public class SelectFirstChild : GameObjectGameObjectFunction
	{
		public override GameObject Call(GameObject entry)
		{
			if (!entry || entry.transform.childCount == 0) return default;

			Transform child = entry.transform.GetChild(0);

			if (!child) return default;

			return child.gameObject;
		}
	}
}