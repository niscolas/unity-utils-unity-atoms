using niscolas.UnityAtomsUtils;
using niscolas.UnityUtils.UnityAtoms;
using UnityAtoms;
using UnityEngine;

namespace UnityAtomsUtils.Conditions
{
	[EditorIcon("atom-icon-teal")]
	[CreateAssetMenu(menuName = Constants.ConditionsCreateAssetMenuPath + "() => Is Editor?")]
	public class IsEditor : VoidCondition
	{
		[SerializeField]
		private bool invert;

		public override bool Call()
		{
			return invert ? !Application.isEditor : Application.isEditor;
		}
	}
}