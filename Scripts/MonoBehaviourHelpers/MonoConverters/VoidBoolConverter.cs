using UnityAtoms;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.MonoConverters {
	public class VoidBoolConverter : BaseMonoConverter<Void, bool> {
		protected override bool Inner_Convert(Void entryValue) {
			return true;
		}
	}
}