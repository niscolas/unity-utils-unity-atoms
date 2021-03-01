using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.MonoConverters {
	[AddComponentMenu("MonoConverters/(Collider) => GameObject")]
	public class ColliderGameObjectConverter : BaseMonoConverter<Collider, GameObject> {
		protected override GameObject Inner_Convert(Collider entryValue) {
			return entryValue.gameObject;
			
		}
	}
}