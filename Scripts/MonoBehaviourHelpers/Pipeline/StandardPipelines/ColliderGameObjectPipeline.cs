using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.Pipeline.StandardPipelines {
	public class ColliderGameObjectPipeline : BasePipeline<
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
		GameObjectColliderFunction> { }
}