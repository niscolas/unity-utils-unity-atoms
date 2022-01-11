using System.Collections.Generic;
using System.Linq;
using UnityAtoms;
using UnityAtoms.Tags;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    public static class AtomTagsExtensions
    {
        public static IEnumerable<GameObject> FilterWithTag(
            this IEnumerable<AtomTags> atomTagsSet, string tag)
        {
            IEnumerable<GameObject> taggedGameObjects = atomTagsSet
                .Where(atomTags => atomTags.HasTag(tag))
                .GameObjects();

            return taggedGameObjects;
        }

        public static IEnumerable<AtomTags> FilterWithTags(
            this IEnumerable<AtomTags> atomTagsSet,
            IEnumerable<string> tags,
            AtomConditionOperators tagOperator)
        {
            IEnumerable<AtomTags> taggedAtomTags = atomTagsSet
                .Where(atomTags =>
                {
                    switch (tagOperator)
                    {
                        case AtomConditionOperators.And:
                            return atomTags.HasAllTags(tags);

                        case AtomConditionOperators.Or:
                            return atomTags.HasAnyTag(tags);
                    }

                    return false;
                });

            return taggedAtomTags;
        }

        public static IEnumerable<GameObject> GameObjects(this IEnumerable<AtomTags> atomTagsSet)
        {
            return atomTagsSet.Select(atomTags => atomTags.gameObject);
        }

        public static bool HasAnyTag(this AtomTags atomTags, IEnumerable<string> tags)
        {
            return tags.Any(atomTags.HasTag);
        }

        public static bool HasAllTags(this AtomTags atomTags, IEnumerable<string> tags)
        {
            return tags.All(atomTags.HasTag);
        }
    }
}