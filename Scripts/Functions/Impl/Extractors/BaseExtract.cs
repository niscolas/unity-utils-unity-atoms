using UnityAtoms;

namespace Plugins.UnityAtomsUtils.Scripts.Functions.Impl.Extractors {
	public abstract class BaseExtract<R, T> : AtomFunction<R, T> {
		public sealed override R Call(T entry) {
			return Extract(entry);
		}

		protected abstract R Extract(T entry);
	}
}