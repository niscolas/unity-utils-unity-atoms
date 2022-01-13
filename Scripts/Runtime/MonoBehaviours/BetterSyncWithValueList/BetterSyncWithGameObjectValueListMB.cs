using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [AddComponentMenu(Constants.AddComponentMenuPrefix + "(GameObject)" + NiceClassSuffix)]
    public class BetterSyncWithGameObjectValueListMB :
        BetterSyncWithValueListMB<GameObject, GameObjectEvent, GameObjectValueList>
    {
        protected override GameObject GetSyncSubject()
        {
            return gameObject;
        }
    }
}