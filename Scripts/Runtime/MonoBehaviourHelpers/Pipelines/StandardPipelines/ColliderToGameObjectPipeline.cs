using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.Pipelines.StandardPipelines {
	public class ColliderToGameObjectPipeline : BasePipeline<
		Collider,
		ColliderPair,
		ColliderConstant,
		ColliderVariable,
		ColliderEvent,
		ColliderPairEvent,
		ColliderColliderFunction,
		ColliderVariableInstancer,
		ColliderReference,
		GameObject> { }
}