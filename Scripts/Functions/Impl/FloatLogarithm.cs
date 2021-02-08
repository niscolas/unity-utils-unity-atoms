using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Functions.Impl {
	[CreateAssetMenu(
		menuName = AtomsConstants.FunctionsCreateAssetMenuPath + "(float) => Log : float ")]
	public class FloatLogarithm : FloatFloatFunction {
		[SerializeField]
		private int logBase = 10;

		public override float Call(float value) {
			return Mathf.Log(value, logBase);
		}
	}
}