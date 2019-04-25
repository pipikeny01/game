using gmae.Interface;

namespace gmae
{
    public enum WeaponType
    {
        刀,
        劍
    }

    public abstract class BaseWeapon
    {
        protected IRandom _random = null;

        public abstract string WeaponName { get; }

        public abstract WeaponType WeaponType { get; }

        public abstract int MaxAttact { get; }

        public abstract int MinAttact { get; }

        public abstract int Speed { get; }

        public BaseWeapon() : this(new DefaultRandom())
        {
        }

        public BaseWeapon(IRandom random)
        {
            _random = random;
        }

        public int RandomAttactValue()
        {
            return _random.Next(MinAttact, MaxAttact);
        }
    }

    public class 倚天劍 : BaseWeapon, ISetWeaponAttribute
    {
        public override string WeaponName => "倚天劍";

        public override WeaponType WeaponType => WeaponType.劍;

        public override int MaxAttact => 13;

        public override int MinAttact => 8;

        public override int Speed => 1000;

        public IWeaponAttribute WeaponAttribute { get; private set; }

        public bool HasAttribute { get; private set; }

        public 倚天劍()
        {
            SetWeaponAttribte(new 冰凍屬性());
        }

        public 倚天劍(IRandom random) : base(random)
        {
        }

        public void SetWeaponAttribte(IWeaponAttribute weaponAttribte)
        {
            this.WeaponAttribute = weaponAttribte;
            this.HasAttribute = true;
        }
    }

    public class 屠龍刀 : BaseWeapon
    {
        public override string WeaponName => "屠龍刀";

        public override WeaponType WeaponType => WeaponType.刀;

        public override int MaxAttact => 20;

        public override int MinAttact => 12;

        public override int Speed => 1300;

        public 屠龍刀()
        {
        }

        public 屠龍刀(IRandom random) : base(random)
        {
        }
    }
}