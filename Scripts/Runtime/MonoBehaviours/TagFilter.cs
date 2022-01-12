﻿using System.Collections.Generic;
using System.Linq;
using niscolas.UnityUtils.Core;
using Sirenix.OdinInspector;
using UnityAtoms.BaseAtoms;
using UnityAtoms.Tags;
using UnityEngine;
using UnityEngine.Events;

namespace niscolas.UnityUtils.UnityAtoms
{
    public class TagFilter : MonoBehaviour
    {
        [SerializeField]
        private bool _filterRoot;

        [Required]
        [SerializeField]
        private List<StringConstant> _tags;

        [ShowIf(nameof(ShowLogicalOperator))]
        [SerializeField]
        private LogicalOperator logicalOperator;

        [Title("Events")]
        [SerializeField]
        private UnityEvent<GameObject> passedFilterResponse;

        private bool ShowLogicalOperator => _tags.Count > 1;

        public void Filter(GameObject otherGameObject)
        {
            if (!otherGameObject ||
                _filterRoot && !otherGameObject.TryFindRoot(out otherGameObject))
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
            if (_tags.Count == 1)
            {
                return otherGameObject.HasTag(_tags[0]);
            }

            bool tagsAreValid = false;

            switch (logicalOperator)
            {
                case LogicalOperator.And:
                    tagsAreValid = otherGameObject.HasAllTags(_tags.Select(currentTag => currentTag.Value));
                    break;

                case LogicalOperator.Or:
                    tagsAreValid = otherGameObject.HasAnyTag(_tags);
                    break;
            }

            return tagsAreValid;
        }
    }
}