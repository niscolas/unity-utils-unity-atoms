namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.MonoConverters {
	public class FloatIntConverter : BaseMonoConverter<float, int> {
		protected override int Inner_Convert(float entryValue) {
			return (int) entryValue;
		}
	}
}