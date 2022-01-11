using UnityAtoms;

namespace niscolas.UnityUtils.UnityAtoms
{
    public abstract class VoidAtomCondition : AtomCondition<Void>
    {
        public abstract bool Call();

        public sealed override bool Call(Void t1)
        {
            return Call();
        }
    }
}