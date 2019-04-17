namespace gmae
{
    /// <summary>
    /// 具有防禦的行為
    /// </summary>
    public interface IDefense
    {
        int DefenseValue {get; }

        void EqipmentArmor(BaseArmor armor);
    }
}