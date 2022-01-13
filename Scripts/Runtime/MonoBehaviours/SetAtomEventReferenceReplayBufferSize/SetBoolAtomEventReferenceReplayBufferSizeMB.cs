using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [AddComponentMenu(Constants.AddComponentMenuPrefix + "(Bool)" + NiceClassSuffix)]
    public class SetBoolAtomEventReferenceReplayBufferSizeMB : BaseSetAtomEventReferenceReplayBufferSizeMB<
        bool,
        BoolVariable,
        BoolEvent,
        BoolVariableInstancer,
        BoolEventInstancer,
        BoolEventReference> { }
}