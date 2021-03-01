using UnityAtoms.BaseAtoms;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.Pipelines.StandardPipelines {
	public class FloatToStringPipeline : BasePipeline<
		float,
		FloatPair,
		FloatConstant,
		FloatVariable,
		FloatEvent,
		FloatPairEvent,
		FloatFloatFunction,
		FloatVariableInstancer,
		FloatReference,
		string> { }
}