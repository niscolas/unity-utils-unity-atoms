using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Functions.Impl {
	[CreateAssetMenu(
		menuName = AtomsConstants.FunctionsCreateAssetMenuPath + "(float) => Exponential : float",
		order = AtomsConstants.CreateAssetMenuOrder)]
	public class FloatExponential : FloatFloatFunction {
		[SerializeField]
		private float power = 10;

		public override float Call(float value) {
			return Mathf.Exp(Mathf.Log(value, power));
		}
	}
}