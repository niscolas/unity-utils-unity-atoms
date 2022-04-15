using niscolas.UnityUtils.Core;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [AddComponentMenu(Constants.AddComponentMenuPrefix + "Set Animator Float")]
    public class SetAnimatorFloatMB : CachedMB
    {
#if ODIN_INSPECTOR
        [Sirenix.OdinInspector.Required]
#elif NAUGHTY_ATTRIBUTES
        [NaughtyAttributes.Required]
#endif
        [SerializeField]
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
