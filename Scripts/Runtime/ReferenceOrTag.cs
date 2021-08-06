﻿using System;
using niscolas.UnityExtensions;
using niscolas.UnityUtils.UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityAtomsUtils.Utilities;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers
{
	[Serializable]
	public struct ReferenceOrTag<T>
	{
		[SerializeField]
		private T _value;

		[SerializeField]
		private StringConstant _fallbackTag;

		public GameObject SearchRoot { get; set; }

		public T Value
		{
			get
			{
				if (_value.IsUnityNull())
				{
					if (!SearchRoot)
					{
						_value = AtomTagsUtility.FindComponentByTag<T>(_fallbackTag);
					}
					else
					{
						_value = SearchRoot.GetComponentInChildrenWithTag<T>(_fallbackTag.Value);
					}
				}

				return _value;
			}

			set => _value = value;
		}
	}
}