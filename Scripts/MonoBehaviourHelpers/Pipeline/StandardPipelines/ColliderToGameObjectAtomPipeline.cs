using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.Pipeline.StandardPipelines {
	public class ColliderToGameObjectAtomPipeline : BaseAtomPipeline<
		Collider,
		ColliderPair,
		ColliderConstant,
		ColliderVariable,
		ColliderEvent,
		ColliderPairEvent,
		ColliderVariableInstancer,
		ColliderReference,
		ColliderCondition,
		GameObject,
		GameObjectCondition,
		ColliderColliderFunction,
		AtomFunction<GameObject, Collider>> { }
}