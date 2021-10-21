﻿using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
	[CreateAssetMenu(menuName = UnityAtomsConstants.ConditionsCreateAssetMenuPrefix + "(bool) => Is True?")]
	public class CheckBool : BoolCondition
	{
		[SerializeField]
		private bool invert;

		public override bool Call(bool value)
		{
			return invert ? !value : value;
		}
	}
}