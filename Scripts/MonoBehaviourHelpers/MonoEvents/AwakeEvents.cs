namespace Plugins.Scripts.MonoBehaviourHelpers.MonoEvents
{
	public class AwakeEvents : BaseMonoEvents
	{
		private void Awake()
		{
			Raise();
		}
	}
}