using System;
using Sirenix.OdinInspector;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.Pipeline {
	public class BaseAtomPipeline<
		TEntry, TPEntry, TConstEntry, TVEntry, TE1Entry, TE2Entry, TViEntry, TREntry, TCEntry,
		TExit, TCExit, TFEntryEntry, TFExitEntry> : MonoBehaviour
		where TCEntry : AtomCondition<TEntry>
		where TCExit : AtomCondition<TExit>
		where TFEntryEntry : AtomFunction<TEntry, TEntry>
		where TFExitEntry : AtomFunction<TExit, TEntry>
		where TREntry : AtomReference<TEntry, TPEntry, TConstEntry, TVEntry, TE1Entry, TE2Entry, TFEntryEntry, TViEntry>
		where TPEntry : struct, IPair<TEntry>
		where TConstEntry : AtomBaseVariable<TEntry>
		where TVEntry : AtomVariable<TEntry, TPEntry, TE1Entry, TE2Entry, TFEntryEntry>
		where TE1Entry : AtomEvent<TEntry>
		where TE2Entry : AtomEvent<TPEntry>
		where TViEntry : AtomVariableInstancer<TVEntry, TPEntry, TEntry, TE1Entry, TE2Entry, TFEntryEntry> {
		[Serializable]
		private class CurrentStep : AtomPipeStep<TEntry, TExit, TCEntry, TCExit, TFEntryEntry, TFExitEntry> { }

		[Title("Entry")]
		[HideLabel]
		[SerializeField]
		private TREntry fixedEntryValueRef;

		[Title("Pipeline")]
		[SerializeField]
		private CurrentStep[] steps;

		private TEntry currentEntryValue;
		private TExit currentExitValue;

		public void Execute(TEntry dynamicEntryValue) {
			Internal_Execute(dynamicEntryValue);
		}

		public void Execute() {
			if (fixedEntryValueRef == null) {
				return;
			}

			Internal_Execute(fixedEntryValueRef.Value);
		}

		private void Internal_Execute(TEntry entryValue) {
			if (entryValue == null) {
				return;
			}

			currentEntryValue = entryValue;

			foreach (CurrentStep step in steps) {
				if (!ExecuteStep(step)) {
					return;
				}
			}
		}

		private bool ExecuteStep(CurrentStep step) {
			switch (step.Type) {
				case PipeStepType.EntryCondition:
					return step.EntryCondition.Call(currentEntryValue);

				case PipeStepType.ExitCondition:
					return step.ExitCondition.Call(currentExitValue);

				case PipeStepType.EntryEntryFilter:
					currentEntryValue = step.EntryEntryFilter.Call(currentEntryValue);
					break;

				case PipeStepType.ExitEntryFilter:
					currentExitValue = step.ExitEntryFilter.Call(currentEntryValue);
					break;

				case PipeStepType.EntryEvent:
					step.EntryEventCallback?.Invoke(currentEntryValue);
					break;

				case PipeStepType.ExitEvent:
					step.ExitEventCallback?.Invoke(currentExitValue);
					break;

				default:
					throw new ArgumentOutOfRangeException();
			}

			return true;
		}
	}
}