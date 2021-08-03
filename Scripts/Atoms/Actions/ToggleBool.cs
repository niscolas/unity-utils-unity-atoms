using niscolas.UnityAtomsUtils;
using niscolas.UnityUtils.UnityAtoms;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtomsUtils.Conditions
{
	[EditorIcon("atom-icon-teal")]
	[CreateAssetMenu(menuName = Constants.ActionsCreateAssetMenuPath + "(bool) => Toggle Bool?")]
	public class ToggleBool : AtomAction<bool>
	{
		[SerializeField]
		private BoolVariable _variable;

		public override void Do(bool value)
		{
			Do();
		}

		public override void Do()
		{
			if (!_variable) return;

			_variable.Value = !_variable.Value;
		}
	}
}