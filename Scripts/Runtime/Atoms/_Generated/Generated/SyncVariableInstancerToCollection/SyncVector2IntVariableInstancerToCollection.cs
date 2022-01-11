using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    ///     Adds Variable Instancer's Variable of type UnityEngine.Vector2Int to a Collection or List on OnEnable and removes
    ///     it on OnDestroy.
    /// </summary>
    [AddComponentMenu(
        "Unity Atoms/Sync Variable Instancer to Collection/Sync Vector2Int Variable Instancer to Collection")]
    [EditorIcon("atom-icon-delicate")]
    public class SyncVector2IntVariableInstancerToCollection : SyncVariableInstancerToCollection<Vector2Int,
        Vector2IntVariable, Vector2IntVariableInstancer> { }
}