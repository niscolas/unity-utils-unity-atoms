using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.FilteredActions
{
	public class FilteredAction : MonoBehaviour
	{
		[SerializeField]
		private AtomAction<GameObject> _action;

		[SerializeField]
		private AtomFunction<GameObject, GameObject> _selectGameObjectFunction;

		public void Do(GameObject target)
		{
			if (_selectGameObjectFunction)
			{
				target = _selectGameObjectFunction.Call(target);
			}

			if (_action)
			{
				_action.Do(target);
			}
		}

		public void Do()
		{
			Do(gameObject);
		}
	}
}