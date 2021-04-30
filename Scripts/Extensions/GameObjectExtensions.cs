using System.Collections.Generic;
using System.Linq;
using Plugins.UnityExtensions;
using UnityAtoms.BaseAtoms;
using UnityAtoms.Tags;
using UnityEngine;
using UnityExtensions;

namespace UnityAtomsUtils.Extensions
{
	public static class GameObjectExtensions
	{
		public static T GetComponentFromRoot<T>(this GameObject gameObject) where T : class
		{
			if (!gameObject) return default;

			GameObject root = gameObject.FindRoot();

			if (!root) return default;

			return root.GetComponentInChildren<T>();
		}

		public static IEnumerable<T> GetComponentWithTagFromRoot<T>(this GameObject requester, string tag)
		{
			if (!requester) return default;

			IEnumerable<T> components = GetComponentsInChildrenWithTag<T>(requester.FindRoot(), tag);
			
			return components;
		}

		public static T GetComponentInChildrenWithTag<T>(this GameObject searchRoot, string tag)
		{
			if (!searchRoot) return default;

			GameObject[] taggedChildren = searchRoot.FindChildrenWithTag(tag).ToArray();

			if (taggedChildren.IsNullOrEmpty()) return default;

			foreach (GameObject taggedChild in taggedChildren)
			{
				T component = taggedChild.GetComponent<T>();
				if (!component.IsNull())
				{
					return component;
				}
			}

			return default;
		}

		public static IEnumerable<T> GetComponentsInChildrenWithTag<T>(this GameObject searchRoot, string tag)
		{
			if (!searchRoot) return default;

			GameObject[] taggedChildren = searchRoot.FindChildrenWithTag(tag).ToArray();

			if (taggedChildren.IsNullOrEmpty()) return default;

			return taggedChildren
				.Select(
					taggedChild => taggedChild.GetComponent<T>())
				.Where(
					component => !component.IsNull())
				.ToList();
		}

		public static T IfNullGetComponentFromRoot<T>(this GameObject gameObject, T component) where T : class
		{
			if (!component.IsNull()) return component;

			return gameObject.GetComponentFromRoot<T>();
		}

		public static GameObject FindRoot(this GameObject gameObject)
		{
			GameObject rootGameObject = gameObject
				.FindParentsWithTag(Constants.RootTagValue)
				.FirstOrDefault();

			return rootGameObject;
		}

		public static bool HasAllTags(this GameObject gameObject, IEnumerable<StringConstant> tags)
		{
			bool result = tags
				.Select(gameObject.HasTag)
				.All(hasTag => hasTag);

			return result;
		}

		public static IEnumerable<GameObject> FindWithTagFromRoot(this GameObject startGameObject, string tag)
		{
			GameObject rootGameObject = startGameObject.FindRoot();

			if (!rootGameObject) return default;

			IEnumerable<GameObject> taggedGameObjects = rootGameObject.FindChildrenWithTag(tag);

			return taggedGameObjects;
		}

		public static IEnumerable<GameObject> FindWithTagInHierarchy
		(
			this GameObject startGameObject, string tag, bool searchInParents = true, bool searchInChildren = true
		)
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
			AtomTags[] atomTagsComponentList = gameObject.GetComponentsInParent<AtomTags>();

			return FindWithTag(atomTagsComponentList, tag);
		}

		public static IEnumerable<GameObject> FindChildrenWithTag(this GameObject gameObject, string tag)
		{
			AtomTags[] atomTagsComponentList = gameObject.GetComponentsInChildren<AtomTags>();

			return FindWithTag(atomTagsComponentList, tag);
		}

		private static IEnumerable<GameObject> FindWithTag(IEnumerable<AtomTags> atomTagsCollection, string tag)
		{
			IEnumerable<GameObject> taggedGameObjects = atomTagsCollection
				.Where(
					atomTags => atomTags.HasTag(tag))
				.Select(
					atomTags => atomTags.gameObject);

			return taggedGameObjects;
		}
	}
}