using UnityAtoms;
using UnityEngine;
using UnityEngine.EventSystems;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = Constants.ActionsCreateAssetMenuPrefix + "(GameObject) => Set Event System First Selected")]
    public class SetEventSystemSelectedGameObject : AtomAction<GameObject>
    {
        public override void Do(GameObject entry)
        {
            if (!entry) return;

            EventSystem eventSystem = FindObjectOfType<EventSystem>();
            eventSystem.SetSelectedGameObject(null);
            eventSystem.SetSelectedGameObject(entry);
        }
    }
}