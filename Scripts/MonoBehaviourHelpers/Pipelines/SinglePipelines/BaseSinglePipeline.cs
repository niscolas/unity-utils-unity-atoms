using UnityAtoms;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.Pipelines.SinglePipelines {
	public abstract class
		BaseSinglePipeline<T, TP, TC, TV, TE1, TE2, TF, TVi, TR> : BasePipeline<T, TP, TC, TV, TE1, TE2, TF, TVi, TR, T>
		where TR : AtomReference<T, TP, TC, TV, TE1, TE2, TF, TVi>
		where TP : struct, IPair<T>
		where TC : AtomBaseVariable<T>
		where TV : AtomVariable<T, TP, TE1, TE2, TF>
		where TE1 : AtomEvent<T>
		where TE2 : AtomEvent<TP>
		where TF : AtomFunction<T, T>
		where TVi : AtomVariableInstancer<TV, TP, T, TE1, TE2, TF> { }
}