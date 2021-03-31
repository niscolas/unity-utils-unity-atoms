using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.Scripts.Functions
{
	[CreateAssetMenu(
		menuName = Constants.FunctionsCreateAssetMenuPath + "(float) => Exponential : float",
		order = Constants.CreateAssetMenuOrder)]
	public class FloatExponential : FloatFloatFunction
	{
		[SerializeField]
		private float power = 10;

		public override float Call(float value)
		{
			return Mathf.Exp(Mathf.Log(value, power));
		}
	}
}