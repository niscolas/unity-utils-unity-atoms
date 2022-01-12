using niscolas.UnityUtils.UnityAtoms;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = UnityAtoms.Constants.FunctionsCreateAssetMenuPrefix + "(float) => Inverse Lerp : float")]
    public class InverseLerpAtomFunction : AtomFunction<float, float>
    {
        [SerializeField]
        private FloatReference _a = new FloatReference();

        [SerializeField]
        private FloatReference _b = new FloatReference(1);

        public override float Call(float value)
        {
            return Mathf.InverseLerp(_a.Value, _b.Value, value);
        }
    }
}