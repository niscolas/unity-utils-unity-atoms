using System.Collections.Generic;
using System.Linq;
using Sirenix.Utilities;
using UnityAtoms.BaseAtoms;
using UnityAtoms.Tags;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.Runtime.ClassExtensions
{
	public static class GameObjectExtensions
	{
		private const string RootTagName = "Root";

		public static T GetComponentFromRoot<T>(this GameObject gameObject) where T : class
		{
			if (!gameObject) return null;

			GameObject root = gameObject.FindRoot();

			if (!root) return null;
			
			T component = root.GetComponentInChildren<T>();
			return component;
		}

		public static void GetComponentFromRootIfNull<T>(this GameObject gameObject, ref T component) where T : Component
		{
			if (component) return;

			component = gameObject.GetComponentFromRoot<T>();
		}

		public static GameObject FindRoot(this GameObject gameObject)
		{
			GameObject rootGameObject = gameObject
				.FindParentsWithTag(RootTagName)
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

		public static IEnumerable<GameObject> FindWithTagInHierarchy(
			this GameObject startGameObject, string tag, bool searchInParents = true, bool searchInChildren = true
		)
		{
			if (!startGameObject)
			{
				return null;
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
				foundGameObjects.AddRange(startGameObject.FindChildWithTag(tag));
			}

			return foundGameObjects;
		}

		public static IEnumerable<GameObject> FindParentsWithTag(this GameObject gameObject, string tag)
		{
			AtomTags[] atomTagsComponentList = gameObject.GetComponentsInParent<AtomTags>();

			return FindWithTag(atomTagsComponentList, tag);
		}

		public static IEnumerable<GameObject> FindChildWithTag(this GameObject gameObject, string tag)
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