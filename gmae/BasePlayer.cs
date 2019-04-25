using gmae.Interface;
using System;
using System.Windows.Forms;

namespace gmae
{
    public abstract class BasePlayer
    {
        private readonly Timer timer = new Timer();

        public virtual string Name { get; }

        public virtual int Power { get; }

        public virtual int Hp { get; set; }

        public BaseWeapon Weapon { private set; get; }

        public Action<AttactOTD, BaseWeapon> 每次攻擊的委派 { set; get; }

        public Action 當Hp是0的委派 { set; get; }

        public void EqipmentWeapon(BaseWeapon weapon)
        {
            this.Weapon = weapon;
        }

        public void Attact(BasePlayer targetPlayer)
        {
            if (this.Weapon != null)
            {
                timer.Interval = this.Weapon.Speed;
                timer.Tick += (ss, ee) =>
                {
                    AttactTrigger(targetPlayer);
                };

                timer.Start();
            }
        }

        private void AttactTrigger(BasePlayer targetPlayer)
        {
            var attactValue = GetAttactOTDWithWeapon();
            targetPlayer.遭受攻擊(attactValue);

            每次攻擊的委派?.Invoke(attactValue, this.Weapon);
        }

        private AttactOTD GetAttactOTDWithWeapon()
        {
            if (this.Weapon == null)
            {
                var attactOtd = new AttactOTD();
                attactOtd.AttactValue = Power;
                attactOtd.Attribute = AttactAttribute.無;
                attactOtd.IsLunch = false;
                return attactOtd;
            }
            else
            {
                return GetAtttributeWeaponAttactOTD();
            }
        }

        private AttactOTD GetAtttributeWeaponAttactOTD()
        {
            var attactOtd = new AttactOTD();
            attactOtd.AttactValue = Power + this.Weapon.RandomAttactValue();
            var AtttributeWeapon = this.Weapon as ISetWeaponAttribute;
            if (AtttributeWeapon != null)
            {
                attactOtd.Attribute = AtttributeWeapon.HasAttribute
                    ? AtttributeWeapon.WeaponAttribute.Attribute : AttactAttribute.無;
            }
            else
            {
                attactOtd.Attribute = AttactAttribute.無;
            }
            attactOtd.IsLunch = true;

            return attactOtd;
        }

        public void 遭受攻擊(AttactOTD attact)
        {
            if (this is IDefense)
                this.Hp -= attact.AttactValue - (this as IDefense).DefenseValue;
            else
                this.Hp -= attact.AttactValue;

            if (this.Hp <= 0)
                WenDead();
        }

        private void WenDead()
        {
            StopAttact();
            當Hp是0的委派?.Invoke();
        }

        public void StopAttact()
        {
            timer.Stop();
        }
    }

    public class 成龍 : BasePlayer, IDefense
    {
        public override string Name => "成龍";
        public override int Power => 10;
        public override int Hp { get; set; }

        public int DefenseValue { get; set; }

        public 成龍()
        {
            this.Hp = 200;
        }

        public void EqipmentArmor(BaseArmor armor)
        {
            DefenseValue = armor.DefenseValue;
        }
    }

    public class 李連杰 : BasePlayer
    {
        public override string Name => "李連杰";
        public override int Power => 8;
        public override int Hp { get; set; }

        public 李連杰()
        {
            this.Hp = 220;
        }
    }
}