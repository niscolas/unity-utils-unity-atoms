using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type UnityEngine.Object to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync Object Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncObjectVariableInstancerToCollection : SyncVariableInstancerToCollection<UnityEngine.Object, ObjectVariable, ObjectVariableInstancer> { }
}
