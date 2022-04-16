using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.FunctionsCreateAssetMenuPrefix + "(float) => exp(x) : float")]
    public class FloatExponential : FloatFloatFunction
    {
        [SerializeField]
        private FloatReference _power = new FloatReference(10f);

        public override float Call(float value)
        {
            return Mathf.Pow(value, _power.Value);
        }
    }
}