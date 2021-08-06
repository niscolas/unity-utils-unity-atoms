﻿using System.Collections.Generic;
using System.Linq;
using niscolas.UnityExtensions;
using niscolas.UnityUtils.Core;
using Sirenix.Utilities;
using UnityAtoms;
using UnityAtoms.Tags;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    public static class GameObjectExtensions
    {
        public static bool TryGetComponentFromRoot<T>(this GameObject gameObject, out T component) where T : class
        {
            component = gameObject.GetComponentFromRoot<T>();
            return !component.IsUnityNull();
        }

        public static T GetComponentFromRoot<T>(this GameObject gameObject) where T : class
        {
            GameObject root = gameObject.Root();

            if (!root)
            {
                return default;
            }

            return root.GetComponentInChildren<T>();
        }

        public static IEnumerable<T> GetComponentsWithTagFromRoot<T>(this GameObject gameObject, string tag)
        {
            GameObject root = gameObject.Root();
            IEnumerable<T> components = GetComponentsInChildrenWithTag<T>(root, tag);

            return components;
        }

        public static IEnumerable<T> GetComponentsWithTagsFromRoot<T>(
            this GameObject startGameObject, IEnumerable<string> tags, AtomConditionOperators tagOperator)
        {
            if (!startGameObject)
            {
                return default;
            }

            IEnumerable<T> components =
                FindChildrenWithTag(startGameObject.Root(), tags, tagOperator)
                    .GetComponents<T>();

            return components;
        }

        public static T GetComponentInChildrenWithTag<T>(this GameObject searchRoot, string tag)
        {
            if (!searchRoot)
            {
                return default;
            }

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
            if (!searchRoot)
            {
                return default;
            }

            IEnumerable<GameObject> taggedChildren = searchRoot.FindChildrenWithTag(tag).AsArray();

            if (taggedChildren.IsNullOrEmpty())
            {
                return default;
            }

            return taggedChildren.GetComponents<T>();
        }

        public static bool RootHasTag(this GameObject gameObject, string tag)
        {
            if (!gameObject.TryFindRoot(out GameObject root))
            {
                return false;
            }

            return root.HasTag(tag);
        }

        public static bool HasAllTags(this GameObject gameObject, IEnumerable<string> tags)
        {
            bool result = tags
                .Select(gameObject.HasTag)
                .All(hasTag => hasTag);

            return result;
        }

        public static bool HasAnyTag(this GameObject gameObject, IEnumerable<string> tags)
        {
            bool result = tags
                .Select(gameObject.HasTag)
                .Any(hasTag => hasTag);

            return result;
        }

        public static IEnumerable<GameObject> FindWithTagFromRoot(this GameObject startGameObject, string tag)
        {
            GameObject rootGameObject = startGameObject.Root();

            if (!rootGameObject) return default;

            IEnumerable<GameObject> taggedGameObjects = rootGameObject.FindChildrenWithTag(tag);

            return taggedGameObjects;
        }

        public static IEnumerable<GameObject> FindWithTagInHierarchy(
            this GameObject startGameObject, string tag, bool searchInParents = true, bool searchInChildren = true)
        {
            if (!startGameObject) return default;

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

        public static IEnumerable<GameObject> FindParentsWithTag(this GameObject gameObject, string tag)
        {
            IEnumerable<AtomTags> atomTagsSet = gameObject.GetComponentsInParent<AtomTags>();

            return FilterWithTag(atomTagsSet.GetGameObjects(), tag);
        }

        public static IEnumerable<GameObject> FindChildrenWithTag(this GameObject gameObject, string tag)
        {
            IEnumerable<AtomTags> atomTagsSet = gameObject.GetComponentsInChildren<AtomTags>();

            return FilterWithTag(atomTagsSet.GetGameObjects(), tag);
        }

        public static IEnumerable<GameObject> FindChildrenWithTag(this GameObject gameObject, IEnumerable<string> tag,
            AtomConditionOperators tagOperator)
        {
            IEnumerable<AtomTags> atomTagsSet = gameObject.GetComponentsInChildren<AtomTags>();

            return FilterWithTags(atomTagsSet.GetGameObjects(), tag, tagOperator);
        }

        public static IEnumerable<GameObject> FilterWithTag(this IEnumerable<GameObject> gameObjects, string tag)
        {
            IEnumerable<GameObject> taggedGameObjects = gameObjects
                .Where(atomTags => atomTags.HasTag(tag));

            return taggedGameObjects;
        }

        public static IEnumerable<GameObject> FilterWithTags(
            this IEnumerable<GameObject> gameObjects, IEnumerable<string> tags, AtomConditionOperators tagOperator)
        {
            IEnumerable<GameObject> taggedGameObjects = gameObjects
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

            return taggedGameObjects;
        }
    }
}