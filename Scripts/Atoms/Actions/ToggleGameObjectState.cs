﻿using niscolas.UnityUtils;
using UnityAtoms;
using UnityEngine;

namespace UnityAtomsUtils.Actions
{
	[CreateAssetMenu(
		menuName = AtomsConstants.ActionsCreateAssetMenuPath + "(GameObject) => Toggle Active State")]
	public class ToggleGameObjectState : AtomAction<GameObject>
	{
		public override void Do(GameObject entry)
		{
			if (!entry)
			{
				return;
			}

			entry.SetActive(!entry.activeSelf);
		}
	}
}