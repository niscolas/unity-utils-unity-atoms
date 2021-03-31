﻿using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Audio;

namespace Plugins.Scripts.Actions
{
	[CreateAssetMenu(
		menuName = Constants.ActionsCreateAssetMenuPath + "(float) => Set Exposed Audio Mixer Parameter")]
	public class AudioMixerSetExposedFloatParameter : FloatAction
	{
		[SerializeField]
		private StringReference exposedParamNameRef;

		[SerializeField]
		private AudioMixer audioMixer;

		public override void Do(float value)
		{
			audioMixer.SetFloat(exposedParamNameRef.Value, value);
		}
	}
}