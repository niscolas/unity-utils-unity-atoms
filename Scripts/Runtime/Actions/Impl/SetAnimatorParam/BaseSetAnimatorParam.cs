using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Actions.Impl.SetAnimatorParam {
	public class BaseSetAnimatorParam<T> : AtomAction<UnityEngine.Animator> {
		[SerializeField]
		protected StringReference paramName;

		[SerializeField]
		protected T value;
	}
}