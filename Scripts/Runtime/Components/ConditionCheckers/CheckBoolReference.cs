using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace niscolas.UnityUtils.UnityAtoms
{
    public class CheckBoolReference : MonoBehaviour
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