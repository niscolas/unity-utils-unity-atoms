using System;
using niscolas.UnityUtils.Core;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    public abstract class SaveTransformMB : CachedMB
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