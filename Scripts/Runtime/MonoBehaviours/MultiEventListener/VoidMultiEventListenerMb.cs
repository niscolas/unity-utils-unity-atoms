using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [AddComponentMenu(Constants.AddComponentMenuPrefix + "(Void)" + NiceClassSuffix)]
    public class VoidMultiEventListenerMb : BaseMultiEventListenerMB<
        Void, VoidEvent, VoidBaseEventReference> { }
}