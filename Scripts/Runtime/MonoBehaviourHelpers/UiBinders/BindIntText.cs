using UnityAtoms.BaseAtoms;

namespace Plugins.UnityAtomsUtils.Scripts.Runtime.MonoBehaviourHelpers.UiBinders
{
	public class BindIntText : BaseBindText<
		int,
		IntPair,
		IntConstant,
		IntVariable,
		IntEvent,
		IntPairEvent,
		IntEventInstancer,
		IntEventReference,
		IntIntFunction,
		IntVariableInstancer,
		IntReference>
	{
		protected override string GetFormattedText(int value)
		{
			return value.ToString();
		}
	}
}