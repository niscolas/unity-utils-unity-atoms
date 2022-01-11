using UnityAtoms.BaseAtoms;

namespace niscolas.UnityUtils.UnityAtoms
{
    public class SetBoolAtomEventReferenceReplayBufferSize : BaseSetAtomEventReferenceReplayBufferSize<
        bool,
        BoolVariable,
        BoolEvent,
        BoolVariableInstancer,
        BoolEventInstancer,
        BoolEventReference> { }
}