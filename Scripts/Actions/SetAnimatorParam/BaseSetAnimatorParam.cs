using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.Scripts.Actions.SetAnimatorParam
{
	public class BaseSetAnimatorParam<T> : AtomAction<Animator>
	{
		[SerializeField]
		protected StringReference paramName;

		[SerializeField]
		protected T value;
	}
}