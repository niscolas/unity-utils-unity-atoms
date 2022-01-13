using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [AddComponentMenu(Constants.AddComponentMenuPrefix + "Float" + NiceClassSuffix)]
    public class FloatVariableInstancerUpdaterMB : VariableInstancerUpdaterMB
    <
        FloatVariable,
        FloatPair,
        float,
        FloatEvent,
        FloatPairEvent,
        FloatFloatFunction,
        FloatVariableInstancer
    > { }
}