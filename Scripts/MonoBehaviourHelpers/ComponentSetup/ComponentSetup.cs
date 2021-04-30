#if UNITY_EDITOR
using Sirenix.OdinInspector;
using UnityAtoms.BaseAtoms;
using UnityEditorInternal;
using UnityEngine;

namespace UnityUtils
{
	public class ComponentSetup : MonoBehaviour
	{
		[SerializeField]
		private Component[] _copiedComponents;

		[SerializeField]
		private GameObject _pasteTarget;

		[SerializeField]
		private bool _removeAfterCopied;

		[SerializeField]
		private GameObjectGameObjectFunction _selectGameObjectFunction;

		[Button]
		private void Copy()
		{
			GameObject pasteTarget = _pasteTarget;
			if (!_pasteTarget && _selectGameObjectFunction)
			{
				pasteTarget = _selectGameObjectFunction.Call(gameObject);
			}

			if (!pasteTarget) return;

			foreach (Component component in _copiedComponents)
			{
				ComponentUtility.CopyComponent(component);
				ComponentUtility.PasteComponentAsNew(pasteTarget);

				if (_removeAfterCopied)
				{
					DestroyImmediate(component);
				}
			}

			DestroyImmediate(this);
		}
	}
}
#endif