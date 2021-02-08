using System.Collections.Generic;
using System.Linq;
using Plugins.UnityAtomsUtils.Scripts.ClassExtensions;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.MonoBehaviourHelpers.TagEventRaiser {
	public class BaseTagEventRaiser<T, E, EI> : MonoBehaviour
		where EI : AtomEventInstancer<T, E>
		where E : AtomEvent<T> {
		[SerializeField]
		protected StringReference tag;

		[SerializeField]
		protected bool searchInParents = true;

		[SerializeField]
		protected bool searchInChildren = true;

		public void Raise(GameObject baseGameObject, T value) {
			IEnumerable<GameObject> foundGameObjects =
				baseGameObject.FindWithTagInHierarchy(tag.Value, searchInParents, searchInChildren);
			GameObject firstGameObject = foundGameObjects.FirstOrDefault();

			if (firstGameObject != null) {
				EI eventInstancer = firstGameObject.GetComponent<EI>();

				if (eventInstancer) {
					eventInstancer.Raise(value);
				}
			}
		}
	}
}