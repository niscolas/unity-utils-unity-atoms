using System;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    public abstract class SaveTransform : MonoBehaviour
    {
        [SerializeField]
        private Vector3Reference _saveTarget;

        protected abstract Vector3 GetSaveValue();

        private void Update()
        {
            Save();
        }

        private void Save()
        {
            _saveTarget.Value = GetSaveValue();
        }
    }
}