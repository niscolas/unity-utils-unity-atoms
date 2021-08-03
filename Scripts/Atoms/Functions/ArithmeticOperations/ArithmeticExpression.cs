using System;
using UnityEngine;

namespace niscolas.UnityAtomsMath
{
    [Serializable]
    public struct ArithmeticExpression<T>
    {
        [SerializeField]
        private ArithmeticExpression<T>[] _operations;

        public ArithmeticExpression<T>[] Operations => _operations;
    }
}