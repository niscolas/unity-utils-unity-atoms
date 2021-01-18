using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Functions {
	[CreateAssetMenu(menuName = AtomsConstants.FunctionsCreateAssetMenuPath + "() => Log (Float) ", order = AtomsConstants.CreateAssetMenuOrder)]
	public class FloatLogarithm : FloatFloatFunction {
		[SerializeField]
		private float logBase = 10;

		public override float Call(float value) {
			return Mathf.Log(value, logBase);
		}
	}
}