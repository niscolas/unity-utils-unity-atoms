using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.Scripts.Actions
{
	[CreateAssetMenu(menuName = "Simple Logger", order = Constants.CreateAssetMenuOrder)]
	public class SimpleLogger : AtomAction
	{
		[SerializeField]
		private StringReference defaultMessage;

		public override void Do()
		{
			Debug.Log(defaultMessage.Value);
		}

		public void DoLog(string message)
		{
			Debug.Log(message);
		}
	}
}