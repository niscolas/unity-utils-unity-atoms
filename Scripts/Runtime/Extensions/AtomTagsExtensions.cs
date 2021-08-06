﻿using System.Collections.Generic;
using System.Linq;
using UnityAtoms.Tags;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
	public static class AtomTagsExtensions
	{
		public static IEnumerable<GameObject> GetGameObjects(this IEnumerable<AtomTags> atomTagsSet)
		{
			return atomTagsSet.Select(atomTags => atomTags.gameObject);
		}
	}
}