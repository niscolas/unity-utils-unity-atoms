using UnityAtoms.BaseAtoms;

namespace Plugins.Scripts.MonoBehaviourHelpers.UiBinders
{
	public class BindIntText : BaseBindText<
		int,
		IntPair,
		IntVariable,
		IntEvent,
		IntPairEvent,
		IntEventInstancer,
		IntEventReference,
		IntIntFunction,
		IntVariableInstancer>
	{
		protected override string FormatText(int value)
		{
			return value.ToString();
		}
	}
}