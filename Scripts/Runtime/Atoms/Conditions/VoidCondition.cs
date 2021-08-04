using UnityAtoms;

namespace niscolas.UnityUtils.UnityAtoms
{
	[EditorIcon("atom-icon-teal")]
	public abstract class VoidCondition : AtomCondition<Void>
	{
		public abstract bool Call();

		public sealed override bool Call(Void t1)
		{
			return Call();
		}
	}
}