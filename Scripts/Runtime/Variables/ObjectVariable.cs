using System;
using Plugins.UnityAtomsUtils.Events;
using Plugins.UnityAtomsUtils.Functions;
using Plugins.UnityAtomsUtils.Pairs;
using UnityAtoms;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Plugins.UnityAtomsUtils.Variables {
	/// <summary>
	/// Variable of type `Object`. Inherits from `AtomVariable&lt;Object, ObjectPair, ObjectEvent, ObjectPairEvent, ObjectObjectFunction&gt;`.
	/// </summary>
	[EditorIcon("atom-icon-lush")]
	[CreateAssetMenu(menuName = "Unity Atoms/Variables/Object", fileName = "ObjectVariable")]
	public sealed class
		ObjectVariable : AtomVariable<Object, ObjectPair, ObjectEvent, ObjectPairEvent, ObjectObjectFunction> {
		protected override bool ValueEquals(Object other) {
			throw new NotImplementedException();
		}
	}
}