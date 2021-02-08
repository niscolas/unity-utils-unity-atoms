using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.MonoBehaviourHelpers.TagEventRaiser {
	public class TagVoidEventRaiser : BaseTagEventRaiser<Void, VoidEvent, VoidEventInstancer> {
		public void Raise(GameObject baseGameObject) {
			Raise(baseGameObject, new Void());
		}
	}
}