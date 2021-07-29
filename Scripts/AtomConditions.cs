using System;
using System.Linq;
using niscolas.UnityUtils;
using UnityAtoms;
using UnityEngine;
using UnityExtensions;

namespace niscolas.UnityAtomsUtils
{
    [Serializable]
    public struct AtomConditions<T>
    {
        [SerializeField]
        private AtomCondition<T>[] _conditions;

        [SerializeField]
        private LogicalOperator _operator;

        public bool IsValid()
        {
            return _conditions.IsValid();
        }

        public bool CallAll(T entry)
        {
            if (_conditions.IsNullOrEmpty()) return false;

            bool result = false;
            switch (_operator)
            {
                case LogicalOperator.And:
                    result = _conditions
                        .All(condition =>
                            condition.Call(entry));
                    break;

                case LogicalOperator.Or:
                    result = _conditions
                        .Any(condition =>
                            condition.Call(entry));
                    break;
            }

            return result;
        }
    }
}