using UnityAtoms;
using UnityAtoms.BaseAtoms;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.Pipeline.StandardPipelines {
	public class IntFloatPipeline : BasePipeline<
		int,
		IntPair,
		IntConstant,
		IntVariable,
		IntEvent,
		IntPairEvent,
		IntVariableInstancer,
		IntReference,
		IntCondition,
		float,
		FloatCondition,
		IntIntFunction,
		FloatIntFunction> { }
}