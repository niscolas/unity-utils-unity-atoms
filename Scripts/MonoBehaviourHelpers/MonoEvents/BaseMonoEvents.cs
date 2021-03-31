using UnityEngine;
using UnityEngine.Events;

namespace Plugins.Scripts.MonoBehaviourHelpers.MonoEvents
{
	public class BaseMonoEvents : MonoBehaviour
	{
		[SerializeField]
		private UnityEvent _events;

		protected void Raise()
		{
			_events?.Invoke();
		}
	}
}