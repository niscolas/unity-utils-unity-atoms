using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Conditions.Compare {
	[EditorIcon("atom-icon-teal")]
	[CreateAssetMenu(menuName = AtomsConstants.ConditionsCreateAssetMenuPath + "() => Compare Int")]
	public class VoidCompareInt : VoidCompareBase<
		int,
		IntPair,
		IntConstant,
		IntVariable,
		IntEvent,
		IntPairEvent,
		IntIntFunction,
		IntVariableInstancer,
		IntReference> { }
}