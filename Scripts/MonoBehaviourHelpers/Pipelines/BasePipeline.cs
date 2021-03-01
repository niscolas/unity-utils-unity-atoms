using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.Pipelines {
	public abstract class BasePipeline<
		TEntry,
		TPEntry,
		TCEntry,
		TVEntry,
		TE1Entry,
		TE2Entry,
		TFEntry,
		TViEntry,
		TREntry,
		TExit> : MonoBehaviour
		where TPEntry : struct, IPair<TEntry>
		where TCEntry : AtomBaseVariable<TEntry>
		where TVEntry : AtomVariable<TEntry, TPEntry, TE1Entry, TE2Entry, TFEntry>
		where TE1Entry : AtomEvent<TEntry>
		where TE2Entry : AtomEvent<TPEntry>
		where TFEntry : AtomFunction<TEntry, TEntry>
		where TViEntry : AtomVariableInstancer<TVEntry, TPEntry, TEntry, TE1Entry, TE2Entry, TFEntry>
		where TREntry : AtomReference<TEntry, TPEntry, TCEntry, TVEntry, TE1Entry, TE2Entry, TFEntry, TViEntry> {
		[Serializable]
		private class CurrentStep : AtomPipeStep<TEntry, TExit> { }

		[SerializeField]
		private TREntry fixedEntryValueRef;

		[Title("Pipeline")]
		[SerializeField]
		private List<CurrentStep> steps;

		private TEntry currentEntryValue;
		private TExit currentExitValue;

		public void Execute(TEntry dynamicEntryValue) {
			Internal_Execute(dynamicEntryValue);
		}

		public void Execute() {
			Internal_Execute(fixedEntryValueRef.Value);
		}

		private void Internal_Execute(TEntry entryValue) {
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

				case PipeStepType.ExitExitFilter:
					currentExitValue = step.ExitExitFilter.Call(currentExitValue);
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