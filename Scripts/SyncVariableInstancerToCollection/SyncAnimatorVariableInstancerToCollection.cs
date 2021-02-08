using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type Animator to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync Animator Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncAnimatorVariableInstancerToCollection : SyncVariableInstancerToCollection<Animator, AnimatorVariable, AnimatorVariableInstancer> { }
}
