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

        public Action<int, BaseWeapon> 每次攻擊的委派 { set; get; }

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
            var attactValue = GetRandomAttactValueWithWeapon();
            targetPlayer.遭受攻擊(attactValue);

            if (每次攻擊的委派 != null)
                每次攻擊的委派(attactValue, this.Weapon);
        }

        private int GetRandomAttactValueWithWeapon()
        {
            return this.Weapon == null ? Power : Power + this.Weapon.RandomAttactValue();
        }

        public void 遭受攻擊(int attact)
        {
            if (this is IDefense)
                this.Hp -= attact - (this as IDefense).DefenseValue;
            else
                this.Hp -= attact;

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

    public class Player1 : BasePlayer, IDefense
    {
        public override string Name => "成龍";
        public override int Power => 10;
        public override int Hp { get; set; }

        public int DefenseValue { get; set; }

        public Player1()
        {
            this.Hp = 200;
        }

        public void EqipmentArmor(BaseArmor armor) => DefenseValue = armor.DefenseValue;
    }

    public class Player2 : BasePlayer
    {
        public override string Name => "李連杰";
        public override int Power => 8;
        public override int Hp { get; set; }

        public Player2()
        {
            this.Hp = 220;
        }
    }
}