using System;
using Plugins.MathUtils;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Functions {
	[CreateAssetMenu(
		menuName = AtomsConstants.FunctionsCreateAssetMenuPath + "Perform Math Operation => Float",
		order = AtomsConstants.CreateAssetMenuOrder)]
	public class PerformFloatMathOperationFunc : FloatFloatFunction {
		[SerializeField]
		private BasicMathOperation mathOperation;

		[SerializeField]
		private FloatReference operand2;

		public override float Call(float value) {
			return mathOperation switch {
				BasicMathOperation.Sum => value + operand2.Value,
				BasicMathOperation.Subtract => value - operand2.Value,
				BasicMathOperation.Divide => value / operand2.Value,
				BasicMathOperation.Multiply => value * operand2.Value,
				_ => throw new ArgumentOutOfRangeException()
			};
		}
	}
}