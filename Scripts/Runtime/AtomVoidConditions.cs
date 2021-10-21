using System;
using Void = UnityAtoms.Void;

namespace niscolas.UnityUtils.UnityAtoms
{
    [Serializable]
    public class AtomVoidConditions : AtomConditions<Void>
    {
        public bool CallAll()
        {
            return CallAll(new Void());
        }
    }
}