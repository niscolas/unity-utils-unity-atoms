using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [AddComponentMenu(Constants.AddComponentMenuPrefix + "(Float)" + NiceClassSuffix)]
    public class FloatConditionCheckerMB : BaseConditionCheckerMB<
        float,
        FloatPair,
        FloatConstant,
        FloatVariable,
        FloatEvent,
        FloatPairEvent,
        FloatFloatFunction,
        FloatVariableInstancer,
        FloatReference> { }
}