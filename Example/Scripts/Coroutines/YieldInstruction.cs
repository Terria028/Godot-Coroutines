using System.Collections;

namespace Godot.Coroutines
{
    public abstract class YieldInstruction : IEnumerator
    {
        public object Current => null;
        public abstract bool Condition { get; }

        public bool MoveNext()
        {
            return Condition;
        }

        public void Reset()
        {
        }
    }
}
