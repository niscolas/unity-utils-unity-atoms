using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Actions.Impl.RemoveFromValueList {
	public abstract class BaseRemoveFromValueList<T, E, VL> : AtomAction<T>
		where VL : AtomValueList<T, E>
		where E : AtomEvent<T> {
		[SerializeField]
		private VL valueList;

		public override void Do(T element) {
			valueList.Remove(element);
		}
	}
}