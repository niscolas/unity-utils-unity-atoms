using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [AddComponentMenu(Constants.AddComponentMenuPrefix + "(Void)" + NiceClassSuffix)]
    public class VoidMultiEventListenerMB : BaseMultiEventListenerMB<
        Void, VoidEvent, VoidBaseEventReference> { }
}