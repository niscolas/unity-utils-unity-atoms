using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    public class BetterSyncWithGameObjectValueList :
        BetterSyncWithValueList<GameObject, GameObjectEvent, GameObjectValueList>
    {
        protected override GameObject GetSyncSubject()
        {
            return gameObject;
        }
    }
}