using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Functions {
	[CreateAssetMenu(
		menuName = AtomsConstants.FunctionsCreateAssetMenuPath + "() => Exp (Float) ",
		order = AtomsConstants.CreateAssetMenuOrder)]
	public class FloatExponential : FloatFloatFunction {
		[SerializeField]
		private float power = 10;

		public override float Call(float value) {
			return Mathf.Exp(Mathf.Log(value, power));
		}
	}
}