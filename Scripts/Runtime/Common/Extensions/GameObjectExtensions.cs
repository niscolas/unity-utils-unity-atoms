using System.Collections.Generic;
using System.Linq;
using niscolas.UnityUtils.Core;
using niscolas.UnityUtils.Core.Extensions;
using UnityAtoms;
using UnityAtoms.Tags;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    public static class GameObjectExtensions
    {
        public static IEnumerable<GameObject> FindChildrenWithTag(this GameObject gameObject, string tag)
        {
            IEnumerable<AtomTags> atomTagsSet = gameObject.GetComponentsInChildren<AtomTags>();

            return atomTagsSet.FilterWithTag(tag);
        }

        public static IEnumerable<GameObject> FindChildrenWithTags(
            this GameObject gameObject,
            IEnumerable<string> tags,
            AtomConditionOperators tagOperator)
        {
            IEnumerable<AtomTags> atomTagsSet = gameObject.GetComponentsInChildren<AtomTags>();

            return atomTagsSet
                .FilterWithTags(tags, tagOperator)
                .GameObjects();
        }

        public static IEnumerable<GameObject> FindParentsWithTag(this GameObject gameObject, string tag)
        {
            IEnumerable<AtomTags> atomTagsSet = gameObject.GetComponentsInParent<AtomTags>();

            return atomTagsSet.FilterWithTag(tag);
        }

        public static IEnumerable<GameObject> FindWithTagFromRoot(this GameObject startGameObject, string tag)
        {
            GameObject rootGameObject = startGameObject.Root();

            if (!rootGameObject)
            {
                return default;
            }

            IEnumerable<GameObject> taggedGameObjects = rootGameObject.FindChildrenWithTag(tag);

            return taggedGameObjects;
        }

        public static IEnumerable<GameObject> FindWithTagInHierarchy(
            this GameObject startGameObject,
            string tag,
            bool searchInParents = true,
            bool searchInChildren = true)
        {
            if (!startGameObject)
            {
                return default;
            }

            HashSet<GameObject> foundGameObjects = new HashSet<GameObject>();
            if (startGameObject.HasTag(tag))
            {
                foundGameObjects.Add(startGameObject);
            }

            if (searchInParents)
            {
                foundGameObjects.AddRange(startGameObject.FindParentsWithTag(tag));
            }

            if (searchInChildren)
            {
                foundGameObjects.AddRange(startGameObject.FindChildrenWithTag(tag));
            }

            return foundGameObjects;
        }

        public static T GetComponentInChildrenWithTag<T>(this GameObject searchRoot, string tag)
        {
            GameObject[] taggedChildren = searchRoot.FindChildrenWithTag(tag).ToArray();

            if (taggedChildren.IsNullOrEmpty())
            {
                return default;
            }

            foreach (GameObject taggedChild in taggedChildren)
            {
                T component = taggedChild.GetComponent<T>();
                if (!component.IsUnityNull())
                {
                    return component;
                }
            }

            return default;
        }

        public static IEnumerable<T> GetComponentsInChildrenWithTag<T>(this GameObject searchRoot, string tag)
        {
            IEnumerable<GameObject> taggedChildren = searchRoot.FindChildrenWithTag(tag).ToArray();

            if (taggedChildren.IsNullOrEmpty())
            {
                return default;
            }

            return taggedChildren.GetComponents<T>();
        }

        public static IEnumerable<T> GetComponentsWithTagFromRoot<T>(this GameObject gameObject, string tag)
        {
            GameObject root = gameObject.Root();
            IEnumerable<T> components = GetComponentsInChildrenWithTag<T>(root, tag);

            return components;
        }

        public static IEnumerable<T> GetComponentsWithTagsFromRoot<T>
        (
            this GameObject startGameObject, IEnumerable<string> tags, AtomConditionOperators tagOperator
        )
        {
            IEnumerable<T> components =
                FindChildrenWithTags(startGameObject.Root(), tags, tagOperator)
                    .GetComponents<T>();

            return components;
        }

        public static bool HasAllTags(this GameObject gameObject, IEnumerable<string> tags)
        {
            return AtomTags
                .GetTagsForGameObject(gameObject)
                .HasAllTags(tags);
        }

        public static bool RootHasTag(this GameObject gameObject, string tag)
        {
            if (!gameObject.TryFindRoot(out GameObject root))
            {
                return false;
            }

            return root.HasTag(tag);
        }
    }
}