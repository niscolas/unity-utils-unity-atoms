using UnityAtoms;

namespace Plugins.Scripts.Functions.Extractors
{
	public abstract class BaseExtractor<TR, TT> : AtomFunction<TR, TT>
	{
		public sealed override TR Call(TT entry)
		{
			return entry == null
				? default
				: Extract(entry);
		}

		protected abstract TR Extract(TT entry);
	}
}