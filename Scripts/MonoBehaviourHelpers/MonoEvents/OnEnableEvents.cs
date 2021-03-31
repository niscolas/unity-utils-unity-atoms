namespace Plugins.Scripts.MonoBehaviourHelpers.MonoEvents
{
	public class OnEnableEvents : BaseMonoEvents
	{
		private void OnEnable()
		{
			Raise();
		}
	}
}