using niscolas.UnityAtomsUtils;
using niscolas.UnityUtils.UnityAtoms;
using UnityAtoms;
using UnityEngine;

namespace UnityAtomsUtils.Functions.ChainFunctions
{
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(menuName = Constants.FunctionsCreateAssetMenuPath + "(GameObject) => Chain Function : GameObject")]
	public abstract class GameObjectChainFunction : BaseChainFunction<GameObject> { }
}