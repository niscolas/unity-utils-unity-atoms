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
		private MathOperation mathOperation;

		[SerializeField]
		private FloatReference operand2;

		public override float Call(float value) {
			return mathOperation switch {
				MathOperation.Sum => value + operand2.Value,
				MathOperation.Subtract => value - operand2.Value,
				MathOperation.Divide => value / operand2.Value,
				MathOperation.Multiply => value * operand2.Value,
				_ => throw new ArgumentOutOfRangeException()
			};
		}
	}
}