namespace gmae.Interface
{
    /// <summary>
    /// 定義武器屬性
    /// </summary>
    public interface IWeaponAttribute
    {
        AttactAttribute Attribute { get; }

        string AttributeEvent();
    }

    public class 冰凍屬性 : IWeaponAttribute
    {
        public AttactAttribute Attribute { get => AttactAttribute.冰凍; }
        
        public string AttributeEvent()
        {
            return "冰凍";
        }
    }

    /// <summary>
    /// 武器可裝備屬性
    /// </summary>
    public interface ISetWeaponAttribute
    {
         IWeaponAttribute WeaponAttribute {  get; }

         bool HasAttribute {get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="weaponAttribte"></param>
        void SetWeaponAttribte(IWeaponAttribute weaponAttribte);
    }

}