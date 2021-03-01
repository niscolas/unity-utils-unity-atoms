using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.Pipelines.SinglePipelines {
	public class GameObjectPipeline : BaseSinglePipeline<
		GameObject, 
		GameObjectPair,
		GameObjectConstant,
		GameObjectVariable,
		GameObjectEvent,
		GameObjectPairEvent,
		GameObjectGameObjectFunction,
		GameObjectVariableInstancer, 
		GameObjectReference> { }
}