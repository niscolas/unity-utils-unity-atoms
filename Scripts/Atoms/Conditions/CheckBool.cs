using niscolas.UnityAtomsUtils;
using niscolas.UnityUtils.UnityAtoms;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtomsUtils.Conditions
{
	[EditorIcon("atom-icon-teal")]
	[CreateAssetMenu(menuName = Constants.ConditionsCreateAssetMenuPath + "(bool) => Is True?")]
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