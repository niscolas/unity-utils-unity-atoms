using System.Collections.Generic;
using System.Linq;
using niscolas.UnityUtils;
using niscolas.UnityUtils.Core;
using Sirenix.OdinInspector;
using UnityAtoms.BaseAtoms;
using UnityAtoms.Tags;
using UnityAtomsUtils.Extensions;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtomsUtils.MonoBehaviourHelpers
{
	public class TagFilter : MonoBehaviour
	{
		[SerializeField]
		private bool _filterRoot;

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
			bool tagsAreValid = CheckTagsAreValid(otherGameObject);

			if (!tagsAreValid) return;

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

			GameObject testGameObject = default;

			if (_filterRoot)
			{
				testGameObject = otherGameObject.FindRoot();
			}

			if (!testGameObject) return false;

			switch (logicalOperator)
			{
				case LogicalOperator.And:
					tagsAreValid = testGameObject.HasAllTags(tags.Select(currentTag => currentTag.Value));
					break;

				case LogicalOperator.Or:
					tagsAreValid = testGameObject.HasAnyTag(tags);
					break;
			}

			return tagsAreValid;
		}
	}
}