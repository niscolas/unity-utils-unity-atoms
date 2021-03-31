namespace Plugins.Scripts.MonoBehaviourHelpers.MonoEvents
{
	public class OnDestroyEvents : BaseMonoEvents
	{
		private void OnDestroy()
		{
			Raise();
		}
	}
}