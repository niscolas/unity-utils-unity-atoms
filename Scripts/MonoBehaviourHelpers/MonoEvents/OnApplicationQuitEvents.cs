namespace Plugins.Scripts.MonoBehaviourHelpers.MonoEvents
{
	public class OnApplicationQuitEvents : BaseMonoEvents
	{
		private void OnApplicationQuit()
		{
			Raise();
		}
	}
}