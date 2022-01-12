using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Serialization;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.FunctionsCreateAssetMenuPrefix + "(float) => log(x) : float")]
    public class FloatLogarithm : FloatFloatFunction
    {
        [FormerlySerializedAs("logBase"), SerializeField]
        private int _base = 10;

        public override float Call(float value)
        {
            return Mathf.Log(value, _base);
        }
    }
}