// null object class

namespace nop
{
    class NullShield : ShieldLevel
    {
        public override int ApplyShield()
        {
            return 0;
        }
    }
}