using System;
using System.Collections;
using Sirenix.OdinInspector;
using UnityAtoms;
using UnityEngine;
using UnityEngine.Events;

namespace Plugins.UnityAtomsUtils.Scripts.MonoBehaviourHelpers.Pipelines {
	[Serializable]
	public class AtomPipeStep<TEntry, TExit> {
		private const string BoxGroupName = "base";
		private const string HorizontalGroupName = BoxGroupName + "/horizontal";

		[PropertySpace(10, 10)]
		[BoxGroup(BoxGroupName, false)]
		[HorizontalGroup(HorizontalGroupName, 200)]
		[VerticalGroup(HorizontalGroupName + "/Column1")]
		[ValueDropdown(nameof(GetDetailedPipeStepTypes))]
		[HideLabel]
		[SerializeField]
		private PipeStepType type;


		[PropertySpace(10, 10)]
		[BoxGroup(BoxGroupName, false)]
		[VerticalGroup(HorizontalGroupName + "/Column2")]
		[ShowIf(nameof(IsEntryConditionStep))]
		[ShowInInspector]
		[HideLabel]
		[SerializeField]
		private AtomCondition<TEntry> entryCondition;

		[PropertySpace(10, 10)]
		[BoxGroup(BoxGroupName, false)]
		[VerticalGroup(HorizontalGroupName + "/Column2")]
		[ShowIf(nameof(IsExitConditionStep))]
		[ShowInInspector]
		[HideLabel]
		[SerializeField]
		private AtomCondition<TExit> exitCondition;

		[PropertySpace(10, 10)]
		[BoxGroup(BoxGroupName, false)]
		[VerticalGroup(HorizontalGroupName + "/Column2")]
		[ShowIf(nameof(IsEntryEntryFilterStep))]
		[ShowInInspector]
		[HideLabel]
		[SerializeField]
		private AtomFunction<TEntry, TEntry> entryEntryFilter;

		[PropertySpace(10, 10)]
		[BoxGroup(BoxGroupName, false)]
		[VerticalGroup(HorizontalGroupName + "/Column2")]
		[ShowIf(nameof(IsExitEntryFilterStep))]
		[ShowInInspector]
		[HideLabel]
		[SerializeField]
		private AtomFunction<TExit, TEntry> exitEntryFilter;

		[PropertySpace(10, 10)]
		[BoxGroup(BoxGroupName, false)]
		[VerticalGroup(HorizontalGroupName + "/Column2")]
		[ShowIf(nameof(IsExitExitFilterStep))]
		[ShowInInspector]
		[HideLabel]
		[SerializeField]
		private AtomFunction<TExit, TExit> exitExitFilter;

		[BoxGroup(BoxGroupName, false)]
		[ShowIf(nameof(IsEntryEventStep))]
		[SerializeField]
		private UnityEvent<TEntry> entryEventCallback;

		[BoxGroup(BoxGroupName, false)]
		[ShowIf(nameof(IsExitEventStep))]
		[SerializeField]
		private UnityEvent<TExit> exitEventCallback;

		private IEnumerable GetDetailedPipeStepTypes() {
			ValueDropdownList<PipeStepType> commonPipeStepTypes = new ValueDropdownList<PipeStepType> {
				{$"({typeof(TEntry).Name}) Condition?", PipeStepType.EntryCondition},
				{$"({typeof(TExit).Name}) => {typeof(TEntry).Name}", PipeStepType.EntryEntryFilter},
				{$"Event ({typeof(TEntry).Name})", PipeStepType.EntryEvent},
			};

			if (typeof(TEntry) != typeof(TExit)) {
				ValueDropdownList<PipeStepType> nonSinglePipeSteps = new ValueDropdownList<PipeStepType> {
					{$"({typeof(TExit).Name}) Condition?", PipeStepType.ExitCondition},
					{$"({typeof(TEntry).Name}) => {typeof(TExit).Name}", PipeStepType.ExitEntryFilter},
					{$"({typeof(TExit).Name}) => {typeof(TExit).Name}", PipeStepType.ExitExitFilter},
					{$"Event ({typeof(TExit).Name})", PipeStepType.ExitEvent}
				};
				
				commonPipeStepTypes.AddRange(nonSinglePipeSteps);
			}

			return commonPipeStepTypes;
		}

		public PipeStepType Type => type;

		public AtomCondition<TEntry> EntryCondition => entryCondition;

		public AtomCondition<TExit> ExitCondition => exitCondition;

		public AtomFunction<TEntry, TEntry> EntryEntryFilter => entryEntryFilter;

		public AtomFunction<TExit, TEntry> ExitEntryFilter => exitEntryFilter;

		public AtomFunction<TExit, TExit> ExitExitFilter => exitExitFilter;

		public UnityEvent<TEntry> EntryEventCallback => entryEventCallback;

		public UnityEvent<TExit> ExitEventCallback => exitEventCallback;

		private bool IsEntryConditionStep => type == PipeStepType.EntryCondition;
		private bool IsExitConditionStep => type == PipeStepType.ExitCondition;
		private bool IsEntryEntryFilterStep => type == PipeStepType.EntryEntryFilter;
		private bool IsExitEntryFilterStep => type == PipeStepType.ExitEntryFilter;
		private bool IsExitExitFilterStep => type == PipeStepType.ExitExitFilter;
		private bool IsEntryEventStep => type == PipeStepType.EntryEvent;
		private bool IsExitEventStep => type == PipeStepType.ExitEvent;
	}
}