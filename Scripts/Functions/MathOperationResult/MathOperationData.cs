﻿using System;
using MathUtils;
using UnityEngine;

namespace UnityAtomsUtils.Functions.MathOperationResult
{
	[Serializable]
	public struct MathOperationData<TR>
	{
		[SerializeField]
		private TR fixedOperand1;

		[SerializeField]
		private MathOperation mathOperation;

		[SerializeField]
		private TR operand2;

		public TR FixedOperand1 => fixedOperand1;

		public MathOperation MathOperation => mathOperation;

		public TR Operand2 => operand2;
	}
}