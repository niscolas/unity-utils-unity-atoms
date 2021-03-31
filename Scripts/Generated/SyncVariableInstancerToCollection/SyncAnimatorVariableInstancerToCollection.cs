using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Adds Variable Instancer's Variable of type UnityEngine.Animator to a Collection or List on OnEnable and removes it on OnDestroy. 
    /// </summary>
    [AddComponentMenu("Unity Atoms/Sync Variable Instancer to Collection/Sync Animator Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncAnimatorVariableInstancerToCollection : SyncVariableInstancerToCollection<UnityEngine.Animator, AnimatorVariable, AnimatorVariableInstancer> { }
}
