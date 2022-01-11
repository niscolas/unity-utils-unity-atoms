using UnityAtoms.BaseAtoms;
using UnityAtoms.Tags;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    public static class AtomTagsUtility
    {
        public static T FindComponentByTag<T>(StringConstant tag)
        {
            if (tag == null)
            {
                return default;
            }

            return FindComponentByTag<T>(tag.Value);
        }

        public static T FindComponentByTag<T>(string tag)
        {
            GameObject gameObject = AtomTags.FindByTag(tag);

            if (!gameObject)
            {
                return default;
            }

            T component = gameObject.GetComponent<T>();

            return component;
        }
    }
}