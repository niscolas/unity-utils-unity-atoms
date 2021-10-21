using System;
using System.Linq;
using niscolas.UnityExtensions;
using niscolas.UnityUtils.Core;
using UnityAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [Serializable]
    public class AtomConditions<T>
    {
        [SerializeField]
        protected AtomCondition<T>[] _conditions;

        [SerializeField]
        private LogicalOperator _operator;

        public bool IsValid()
        {
            return _conditions.IsValid();
        }

        public bool CallAll(T entry)
        {
            if (_conditions.IsNullOrEmpty())
            {
                return false;
            }

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