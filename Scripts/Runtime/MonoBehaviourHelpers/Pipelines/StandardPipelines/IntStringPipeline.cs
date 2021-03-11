using UnityAtoms.BaseAtoms;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.Pipelines.StandardPipelines {
	public class IntStringPipeline : BasePipeline<
		int,
		IntPair,
		IntConstant,
		IntVariable,
		IntEvent,
		IntPairEvent,
		IntIntFunction,
		IntVariableInstancer,
		IntReference,
		string> { }
}