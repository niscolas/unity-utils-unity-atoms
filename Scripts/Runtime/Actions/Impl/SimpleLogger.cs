using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Actions.Impl {
	[CreateAssetMenu(menuName = "Simple Logger", order = AtomsConstants.CreateAssetMenuOrder)]
	public class SimpleLogger : AtomAction {
		[SerializeField]
		private StringReference defaultMessage;

		public override void Do() {
			Debug.Log(defaultMessage.Value);
		}

		public void DoLog(string message) {
			Debug.Log(message);
		}
	}
}