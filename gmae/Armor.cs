namespace gmae
{
    public abstract class BaseArmor
    {
        public abstract int DefenseValue { get; }
    }

    public class 布甲 : BaseArmor
    {
        public override int DefenseValue => 3;
    }
}