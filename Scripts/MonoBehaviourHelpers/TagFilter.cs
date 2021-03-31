using System.Collections.Generic;
using MathUtils;
using Plugins.Scripts.ClassExtensions;
using Sirenix.OdinInspector;
using UnityAtoms.BaseAtoms;
using UnityAtoms.Tags;
using UnityEngine;
using UnityEngine.Events;

namespace Plugins.Scripts.MonoBehaviourHelpers
{
	public class TagFilter : MonoBehaviour
	{
		[Required]
		[SerializeField]
		private List<StringConstant> tags;

		[ShowIf(nameof(ShowLogicalOperator))]
		[SerializeField]
		private LogicalOperator logicalOperator;

		[Title("Response")]
		[SerializeField]
		private UnityEvent<GameObject> passedFilterResponse;

		private bool ShowLogicalOperator => tags.Count > 1;

		public void Filter(GameObject otherGameObject)
		{
			if (!otherGameObject)
			{
				return;
			}

			bool tagsAreValid = CheckTagsAreValid(otherGameObject);
			if (!tagsAreValid)
			{
				return;
			}

			passedFilterResponse?.Invoke(otherGameObject);
		}

		public void Filter(Collider otherCollider)
		{
			if (!otherCollider)
			{
				return;
			}

			Filter(otherCollider.gameObject);
		}

		private bool CheckTagsAreValid(GameObject otherGameObject)
		{
			bool tagsAreValid = false;

			switch (logicalOperator)
			{
				case LogicalOperator.And:
					tagsAreValid = otherGameObject.HasAllTags(tags);
					break;

				case LogicalOperator.Or:
					tagsAreValid = otherGameObject.HasAnyTag(tags);
					break;
			}

			return tagsAreValid;
		}
	}
}