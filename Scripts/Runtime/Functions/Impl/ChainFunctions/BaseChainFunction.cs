using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Functions.Impl.ChainFunctions {
	[EditorIcon("atom-icon-sand")]
	public abstract class BaseChainFunction<T> : AtomFunction<T, T> {
		[SerializeField]
		private AtomFunction<T, T>[] chainedFunctions;

		public sealed override T Call(T entry) {
			T result = entry;

			foreach (AtomFunction<T, T> chainedFunction in chainedFunctions) {
				result = chainedFunction.Call(result);
			}

			return result;
		}
	}
}