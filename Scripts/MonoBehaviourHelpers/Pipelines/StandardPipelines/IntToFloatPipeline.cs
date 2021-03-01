using UnityAtoms.BaseAtoms;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.Pipelines.StandardPipelines {
	public class IntToFloatPipeline : BasePipeline<
		int,
		IntPair,
		IntConstant,
		IntVariable,
		IntEvent,
		IntPairEvent,
		IntIntFunction,
		IntVariableInstancer,
		IntReference,
		float> { }
}