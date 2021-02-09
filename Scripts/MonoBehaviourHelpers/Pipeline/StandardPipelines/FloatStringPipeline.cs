using UnityAtoms;
using UnityAtoms.BaseAtoms;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.Pipeline.StandardPipelines {
	public class FloatStringPipeline : BasePipeline<
		float,
		FloatPair,
		FloatConstant,
		FloatVariable,
		FloatEvent,
		FloatPairEvent,
		FloatVariableInstancer,
		FloatReference,
		FloatCondition,
		string,
		StringCondition,
		FloatFloatFunction,
		StringFloatFunction> { }
}