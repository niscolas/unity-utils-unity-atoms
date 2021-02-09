using UnityAtoms;
using UnityAtoms.BaseAtoms;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.Pipeline.StandardPipelines {
	public class FloatToStringAtomPipeline : BaseAtomPipeline<
		float,
		FloatPair,
		FloatConstant,
		FloatVariable,
		FloatEvent,
		FloatPairEvent,
		FloatVariableInstancer,
		FloatReference,
		FloatCondition,
		int,
		IntCondition,
		FloatFloatFunction,
		AtomFunction<int, float>> { }
}