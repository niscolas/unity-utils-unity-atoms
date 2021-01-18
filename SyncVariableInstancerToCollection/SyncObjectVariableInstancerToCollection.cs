using Plugins.UnityAtomsUtils.VariableInstancers;
using Plugins.UnityAtomsUtils.Variables;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Plugins.UnityAtomsUtils.SyncVariableInstancerToCollection
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type Object to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync Object Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncObjectVariableInstancerToCollection : SyncVariableInstancerToCollection<Object, ObjectVariable, ObjectVariableInstancer> { }
}
