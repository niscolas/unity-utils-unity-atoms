using System;
using Sirenix.OdinInspector;
using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.Pipeline {
	[Serializable]
	public class AtomPipeStep<TEntry, TExit, TCEntry, TCExit, TFEntryEntry, TFExitEntry>
		where TCEntry : AtomCondition<TEntry>
		where TCExit : AtomCondition<TExit>
		where TFEntryEntry : AtomFunction<TEntry, TEntry>
		where TFExitEntry : AtomFunction<TExit, TEntry> {
		private const float ConditionLabelWidth = 75f;

		[HorizontalGroup("Step", Width = 0.25f)]
		[VerticalGroup("Step/Column1")]
		[SerializeField]
		[HideLabel]
		private PipeStepType type;

		[VerticalGroup("Step/Column2")]
		[ShowIf(nameof(IsEntryConditionStep))]
		[LabelText("Proceed if")]
		[LabelWidth(ConditionLabelWidth)]
		[SerializeField]
		private TCEntry entryCondition;

		[VerticalGroup("Step/Column2")]
		[ShowIf(nameof(IsExitConditionStep))]
		[LabelText("Proceed if")]
		[LabelWidth(ConditionLabelWidth)]
		[SerializeField]
		private TCExit exitCondition;

		[VerticalGroup("Step/Column2")]
		[ShowIf(nameof(IsEntryEntryFilterStep))]
		[HideLabel]
		[SerializeField]
		private TFEntryEntry entryEntryFilter;

		[VerticalGroup("Step/Column2")]
		[ShowIf(nameof(IsExitEntryFilterStep))]
		[HideLabel]
		[SerializeField]
		private TFExitEntry exitEntryFilter;

		[VerticalGroup("Step/Column2")]
		[ShowIf(nameof(IsEntryEventStep))]
		[HideLabel]
		[SerializeField]
		private UnityEvent<TEntry> entryEventCallback;

		[VerticalGroup("Step/Column2")]
		[ShowIf(nameof(IsExitEventStep))]
		[HideLabel]
		[SerializeField]
		private UnityEvent<TExit> exitEventCallback;

		public PipeStepType Type => type;
		public TCEntry EntryCondition => entryCondition;
		public TCExit ExitCondition => exitCondition;
		public TFEntryEntry EntryEntryFilter => entryEntryFilter;
		public TFExitEntry ExitEntryFilter => exitEntryFilter;
		public UnityEvent<TEntry> EntryEventCallback => entryEventCallback;
		public UnityEvent<TExit> ExitEventCallback => exitEventCallback;

		private bool IsEntryConditionStep => type == PipeStepType.EntryCondition;
		private bool IsExitConditionStep => type == PipeStepType.ExitCondition;
		private bool IsEntryEntryFilterStep => type == PipeStepType.EntryEntryFilter;
		private bool IsExitEntryFilterStep => type == PipeStepType.ExitEntryFilter;
		private bool IsEntryEventStep => type == PipeStepType.EntryEvent;
		private bool IsExitEventStep => type == PipeStepType.ExitEvent;
	}
}