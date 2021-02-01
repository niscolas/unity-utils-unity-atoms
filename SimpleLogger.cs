using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils {
	[CreateAssetMenu(menuName = "Simple Logger", order = AtomsConstants.CreateAssetMenuOrder)]
	public class SimpleLogger : AtomAction {
		[SerializeField]
		private StringReference defaultMessage;

		[SerializeField]
		private bool isActive = true;

		public override void Do() {
			DoLog(defaultMessage.Value);
		}

		public void DoLog(string message) {
			if (!isActive) {
				return;
			}
			
			Debug.Log(message);
		}
	}
}