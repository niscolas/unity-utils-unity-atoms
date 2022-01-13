using niscolas.UnityUtils.Core;
using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace niscolas.UnityUtils.UnityAtoms
{
    [AddComponentMenu(Constants.AddComponentMenuPrefix + "Filtered Action")]
    public class FilteredActionMB : CachedMonoBehaviour
    {
        [SerializeField]
        private AtomFunction<GameObject, GameObject> _selectGameObjectFunction;

        [Header(HeaderTitles.Events)]
        [SerializeField]
        private UnityEvent<GameObject> _onFiltered;

        public void Do()
        {
            Do(_gameObject);
        }

        public void Do(GameObject target)
        {
            if (_selectGameObjectFunction)
            {
                target = _selectGameObjectFunction.Call(target);
            }

            _onFiltered?.Invoke(target);
        }
    }
}