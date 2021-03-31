﻿using UnityAtoms;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Plugins.Scripts.Actions
{
	[CreateAssetMenu(
		menuName = Constants.ActionsCreateAssetMenuPath + "(GameObject) => Set Event System First Selected")]
	public class SetEventSystemFirstSelected : AtomAction<GameObject>
	{
		public override void Do(GameObject entry)
		{
			if (!entry)
			{
				return;
			}

			EventSystem eventSystem = FindObjectOfType<EventSystem>();
			eventSystem.SetSelectedGameObject(entry);
		}
	}
}