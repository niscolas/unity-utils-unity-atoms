using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.Pipeline.SinglePipelines {
	public class GameObjectAtomPipeline : BaseSingleAtomPipeline<
		GameObject,
		GameObjectPair,
		GameObjectConstant,
		GameObjectVariable,
		GameObjectEvent,
		GameObjectPairEvent,
		GameObjectGameObjectFunction,
		GameObjectVariableInstancer,
		GameObjectReference,
		GameObjectCondition> { }
}