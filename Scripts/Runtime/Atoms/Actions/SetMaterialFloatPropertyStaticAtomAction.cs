using niscolas.UnityUtils.UnityAtoms;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = UnityAtoms.Constants.ActionsCreateAssetMenuPrefix + "() => Set Material Float Property")]
    public class SetMaterialFloatPropertyStaticAtomAction : AtomAction<Void>
    {
        [SerializeField]
        private StringReference _propertyName;

        [SerializeField]
        private Material _material;

        [SerializeField]
        private FloatReference _value;

        public override void Do()
        {
            _material.SetFloat(_propertyName.Value, _value.Value);
        }
    }
}