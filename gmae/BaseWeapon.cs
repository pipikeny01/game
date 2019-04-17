using System;

namespace gmae
{
    public enum WeaponType
    {
        刀,
        劍
    }

    public abstract class BaseWeapon
    {
        public abstract string WeaponName { get; }

        public abstract WeaponType WeaponType { get; }

        public abstract int MaxAttact {  get; }

        public abstract int MinAttact { get; }

        public abstract int Speed { get; }

        public int RandomAttactValue()
        {
            return new Random().Next(MinAttact, MaxAttact);
        }
    }

    public class 倚天劍 : BaseWeapon
    {
        public override string WeaponName => "倚天劍";

        public override WeaponType WeaponType =>  WeaponType.劍;

        public override int MaxAttact => 13;

        public override int MinAttact => 8;

        public override int Speed => 1000;
    }

    public class 屠龍刀 : BaseWeapon
    {
        public override string WeaponName => "屠龍刀";

        public override WeaponType WeaponType => WeaponType.刀;

        public override int MaxAttact => 20;

        public override int MinAttact => 12;

        public override int Speed => 1300;
    }

}