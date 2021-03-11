using UnityAtoms.BaseAtoms;

namespace Plugins.UnityAtomsUtils.Scripts.Runtime.MonoBehaviourHelpers.UiBinders {
	public class UpdateIntText : BaseUpdateText<
		int, IntPair, IntConstant, IntVariable, IntEvent, IntPairEvent, IntIntFunction, IntVariableInstancer, IntReference
	> {
		protected override string GetFormattedText(int value) {
			return value.ToString();
		}
	}
}