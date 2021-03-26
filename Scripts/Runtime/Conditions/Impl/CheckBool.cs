using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Runtime.Conditions.Impl
{
	[EditorIcon("atom-icon-teal")]
	[CreateAssetMenu(menuName = AtomsConstants.ConditionsCreateAssetMenuPath + "(bool) => Is True?")]
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