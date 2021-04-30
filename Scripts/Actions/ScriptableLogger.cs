using UnityAtoms;
using UnityEngine;

namespace UnityAtomsUtils.Actions
{
	[CreateAssetMenu(
		menuName = "Logger", 
		order = Constants.CreateAssetMenuOrder)]
	public class ScriptableLogger : AtomAction<string>
	{
		public override void Do(string message)
		{
			Debug.Log(message);
		}
	}
}