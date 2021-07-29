using niscolas.UnityAtomsUtils;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtomsUtils.Functions
{
	[CreateAssetMenu(
		menuName = Constants.FunctionsCreateAssetMenuPath + "(float) => Log : float ")]
	public class FloatLogarithm : FloatFloatFunction
	{
		[SerializeField]
		private int logBase = 10;

		public override float Call(float value)
		{
			return Mathf.Log(value, logBase);
		}
	}
}