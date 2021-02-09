using UnityAtoms;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.Pipeline.SinglePipelines {
	public abstract class BaseSingleAtomPipeline<
		T, TP, TConst, TV, TE1, TE2, TF, TVi, TR, TC> : 
		BaseAtomPipeline<
		T, TP, TConst, TV, TE1, TE2, TVi, TR, TC, T, TC, TF, TF>
		where TP : struct, IPair<T>
		where TConst : AtomBaseVariable<T>
		where TV : AtomVariable<T, TP, TE1, TE2, TF>
		where TE1 : AtomEvent<T>
		where TE2 : AtomEvent<TP>
		where TR : AtomReference<T, TP, TConst, TV, TE1, TE2, TF, TVi>
		where TC : AtomCondition<T>
		where TF : AtomFunction<T, T>
		where TVi : AtomVariableInstancer<TV, TP, T, TE1, TE2, TF> { }
}