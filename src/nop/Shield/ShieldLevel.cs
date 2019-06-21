// abstract class to define what methods and properties shield types will have
// also this class define an accessible static member to represent the null objects

namespace nop
{
    public abstract class ShieldLevel
    {
        public abstract int ApplyShield();
        public static ShieldLevel Null { get; } = new NullShield();
    }
}