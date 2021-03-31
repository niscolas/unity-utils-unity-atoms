using UnityAtoms.BaseAtoms;

namespace Plugins.Scripts.MonoBehaviourHelpers.MonoInputInterpreters
{
	public class FloatMonoInputInterpreter : BaseMonoInputInterpreter<
		float,
		FloatPair,
		FloatConstant,
		FloatVariable,
		FloatEvent,
		FloatPairEvent,
		FloatEventInstancer,
		FloatEventReference,
		FloatFloatFunction,
		FloatVariableInstancer,
		FloatReference> { }
}