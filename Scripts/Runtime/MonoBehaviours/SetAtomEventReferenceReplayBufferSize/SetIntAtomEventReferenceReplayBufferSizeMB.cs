using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [AddComponentMenu(Constants.AddComponentMenuPrefix + "(Int)" + NiceClassSuffix)]
    public class SetIntAtomEventReferenceReplayBufferSizeMB : BaseSetAtomEventReferenceReplayBufferSizeMB<
        int,
        IntVariable,
        IntEvent,
        IntVariableInstancer,
        IntEventInstancer,
        IntEventReference> { }
}