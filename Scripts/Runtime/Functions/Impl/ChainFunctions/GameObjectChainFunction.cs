using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Functions.Impl.ChainFunctions {
	[EditorIcon("atom-icon-sand")]
	[CreateAssetMenu(menuName = AtomsConstants.FunctionsCreateAssetMenuPath + "(GameObject) => Chain Function : GameObject")]
	public abstract class GameObjectChainFunction : BaseChainFunction<GameObject> { }
}