using niscolas.UnityUtils.Core;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace niscolas.UnityUtils.UnityAtoms
{
    [AddComponentMenu(Constants.AddComponentMenuPrefix + "Check Bool Reference")]
    public class CheckBoolReferenceMB : CachedMonoBehaviour
    {
        [SerializeField]
        private BoolReference _value;

        [Header("Events")]
        [SerializeField]
        private UnityEvent _onConditionMet;

        [SerializeField]
        private UnityEvent _onConditionFailed;

        public void Check()
        {
            if (_value.Value)
            {
                _onConditionMet?.Invoke();
            }
            else
            {
                _onConditionFailed?.Invoke();
            }
        }
    }
}