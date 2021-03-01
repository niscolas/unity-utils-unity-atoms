using UnityAtoms.BaseAtoms;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.Pipelines.StandardPipelines {
	public class FloatToIntPipeline : BasePipeline<
		float,
		FloatPair,
		FloatConstant,
		FloatVariable,
		FloatEvent,
		FloatPairEvent,
		FloatFloatFunction,
		FloatVariableInstancer,
		FloatReference,
		int> { }
}