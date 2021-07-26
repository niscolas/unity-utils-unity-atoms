using System.Collections.Generic;
using System.Linq;
using UnityAtoms.Tags;
using UnityEngine;

namespace UnityAtomsUtils.Extensions
{
	public static class AtomTagsExtensions
	{
		public static IEnumerable<GameObject> GetGameObjects(this IEnumerable<AtomTags> atomTagsSet)
		{
			return atomTagsSet.Select(atomTags => atomTags.gameObject);
		}
	}
}