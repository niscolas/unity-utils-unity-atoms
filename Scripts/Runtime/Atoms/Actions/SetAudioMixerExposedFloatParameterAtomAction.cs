using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.Audio;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.ActionsCreateAssetMenuPrefix + "(float) => Set Exposed Audio Mixer Parameter")]
    public class SetAudioMixerExposedFloatParameterAtomAction : FloatAction
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