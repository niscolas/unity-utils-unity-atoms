using System;
using UnityAtoms.BaseAtoms;
using UnityAtomsUtils.Extensions;
using UnityAtomsUtils.Utilities;
using UnityEngine;
using UnityExtensions;

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
				if (_value.IsNull())
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