using System.Collections.Generic;
using System.Linq;
using Sirenix.Utilities;
using UnityAtoms.Tags;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.ClassExtensions {
	public static class GameObjectExtensions {
		private const string RootTagName = "Root";

		public static GameObject GetRoot(this GameObject gameObject) {
			return gameObject.FindWithTagInHierarchy(RootTagName, true, false).FirstOrDefault();
		}

		public static IEnumerable<GameObject> FindWithTagInHierarchy(
			this GameObject startGameObject, string tag, bool searchInParents = true, bool searchInChildren = true
		) {
			if (!startGameObject) {
				return null;
			}

			HashSet<GameObject> foundGameObjects = new HashSet<GameObject>();
			if (startGameObject.HasTag(tag)) {
				foundGameObjects.Add(startGameObject);
			}

			if (searchInParents) {
				foundGameObjects.AddRange(startGameObject.FindParentsWithTag(tag));
			}

			if (searchInChildren) {
				foundGameObjects.AddRange(startGameObject.FindChildWithTag(tag));
			}

			return foundGameObjects;
		}

		public static IEnumerable<GameObject> FindParentsWithTag(this GameObject gameObject, string tag) {
			return FindWithTagInList(
				gameObject.GetComponentsInParent<AtomTags>(), tag
			);
		}

		public static IEnumerable<GameObject> FindChildWithTag(this GameObject gameObject, string tag) {
			return FindWithTagInList(
				gameObject.GetComponentsInChildren<AtomTags>(), tag
			);
		}

		private static IEnumerable<GameObject> FindWithTagInList(IEnumerable<AtomTags> atomTagsComponentList, string tag) {
			List<GameObject> foundGameObjects = new List<GameObject>();

			foreach (AtomTags atomTags in atomTagsComponentList) {
				if (atomTags.HasTag(tag)) {
					foundGameObjects.Add(atomTags.gameObject);
				}
			}

			return foundGameObjects;
		}
	}
}