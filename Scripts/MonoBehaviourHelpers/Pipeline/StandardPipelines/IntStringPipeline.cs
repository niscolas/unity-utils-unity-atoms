using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.Pipeline.StandardPipelines {
	public class IntStringPipeline : BasePipeline<
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
		StringIntFunction> { }
}