using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Conditions.Compare {
	[EditorIcon("atom-icon-teal")]
	[CreateAssetMenu(menuName = AtomsConstants.ConditionsCreateAssetMenuPath + "(int) => Compare Int")]
	public class NonVoidCompareInt : NonVoidCompareBase<
		int,
		IntPair,
		IntConstant,
		IntVariable,
		IntEvent,
		IntPairEvent,
		IntIntFunction,
		IntVariableInstancer,
		IntReference,
		int> { }
}