namespace gmae
{
    public enum AttactAttribute
    {
        無,
        冰凍,
        燃燒
    }
    public class AttactOTD
    {
        public AttactAttribute Attribute { get; set; }
        public int AttactValue { get; set; }
        public bool IsLunch { get; set; }
    }
}