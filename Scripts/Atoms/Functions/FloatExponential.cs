using niscolas.UnityAtomsUtils;
using niscolas.UnityUtils.UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityAtomsUtils;
using UnityEngine;
using UnityEngine.Serialization;

namespace niscolas.UnityAtomsMath
{
    [CreateAssetMenu(
        menuName = Constants.FunctionsCreateAssetMenuPath + "(float) => exp(x) : float")]
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