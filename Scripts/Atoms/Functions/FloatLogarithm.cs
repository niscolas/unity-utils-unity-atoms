using niscolas.UnityAtomsUtils;
using niscolas.UnityUtils.UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityAtomsUtils;
using UnityEngine;
using UnityEngine.Serialization;

namespace niscolas.UnityAtomsMath
{
    [CreateAssetMenu(
        menuName = Constants.FunctionsCreateAssetMenuPath + "(float) => log(x) : float")]
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