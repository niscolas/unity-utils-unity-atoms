using niscolas.UnityUtils.Core;
using Sirenix.OdinInspector;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    public class SetAnimatorFloat : CachedMonoBehaviour
    {
        [Required, SerializeField]
        private Animator _animator;

        [SerializeField]
        private StringReference _param;

        [SerializeField]
        private FloatReference _fixedValue = new FloatReference();

        public void Do()
        {
            Do(_fixedValue.Value);
        }

        public void Do(float value)
        {
            _animator.SetFloat(_param.Value, value);
        }
    }
}