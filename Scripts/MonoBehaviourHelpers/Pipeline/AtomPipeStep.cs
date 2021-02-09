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
		private const string BoxGroupName = "base"; 
		
		[BoxGroup(BoxGroupName, false)]
		[SerializeField]
		private PipeStepType type;

		[BoxGroup(BoxGroupName, false)]
		[Space]
		[ShowIf(nameof(IsEntryConditionStep))]
		[SerializeField]
		private TCEntry entryCondition;

		[BoxGroup(BoxGroupName, false)]
		[Space]
		[ShowIf(nameof(IsExitConditionStep))]
		[SerializeField]
		private TCExit exitCondition;

		[BoxGroup(BoxGroupName, false)]
		[Space]
		[ShowIf(nameof(IsEntryEntryFilterStep))]
		[HideLabel]
		[SerializeField]
		private TFEntryEntry entryEntryFilter;

		[BoxGroup(BoxGroupName, false)]
		[Space]
		[ShowIf(nameof(IsExitEntryFilterStep))]
		[HideLabel]
		[SerializeField]
		private TFExitEntry exitEntryFilter;

		[BoxGroup(BoxGroupName, false)]
		[Space]
		[ShowIf(nameof(IsEntryEventStep))]
		[SerializeField]
		private UnityEvent<TEntry> entryEventCallback;

		[BoxGroup(BoxGroupName, false)]
		[Space]	
		[ShowIf(nameof(IsExitEventStep))]
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