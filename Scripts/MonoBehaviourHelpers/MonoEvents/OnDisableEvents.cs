﻿namespace Plugins.Scripts.MonoBehaviourHelpers.MonoEvents
{
	public class OnDisableEvents : BaseMonoEvents
	{
		private void OnDisable()
		{
			Raise();
		}
	}
}