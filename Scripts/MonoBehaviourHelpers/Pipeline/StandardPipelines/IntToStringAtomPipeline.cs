using UnityAtoms;
using UnityAtoms.BaseAtoms;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.Pipeline.StandardPipelines {
	public class IntToStringAtomPipeline : BaseAtomPipeline<
		int,
		IntPair,
		IntConstant,
		IntVariable,
		IntEvent,
		IntPairEvent,
		IntVariableInstancer,
		IntReference,
		IntCondition,
		string,
		StringCondition,
		IntIntFunction,
		AtomFunction<string, int>> { }
}