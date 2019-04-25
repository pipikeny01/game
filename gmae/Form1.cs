using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace gmae
{
    public partial class Form1 : Form
    {
        private EquipmentFactory equipmentFactory = new EquipmentFactory();
        private 成龍 player1 = new 成龍();
        private 李連杰 player2 = new 李連杰();

        public Form1()
        {
            InitializeComponent();

            Player1Status();
            Player2Status();

            player1.EqipmentWeapon(equipmentFactory.Get屠龍刀());
            player1.EqipmentArmor(equipmentFactory.Get布甲());
            player2.EqipmentWeapon(equipmentFactory.Get倚天劍());

            player1.每次攻擊的委派 += (attactValue, weapon) =>
            {
                Player1Status();
                AttactLog(txtPlayer1Log,player1, attactValue, weapon);
            };

            player1.當Hp是0的委派 += () =>
            {
                player2.StopAttact();
                txtPlayer1Log.Text += $"{player1.Name}輸了";
            };

            player2.每次攻擊的委派 += (attactValue, weapon) =>
            {
                Player2Status();
                AttactLog(txtPlayer2Log,player2, attactValue, weapon);
            };

            player2.當Hp是0的委派 += () =>
            {
                player1.StopAttact();
                txtPlayer2Log.Text += $"{player2.Name}輸了";
            };
        }

        private void AttactLog(TextBox txtPlayerLog,BasePlayer player, AttactOTD attactValue, BaseWeapon weapon)
        {
            txtPlayerLog.Text += $"{player.Name}拿著{weapon.WeaponName}發動{attactValue.Attribute}攻擊造成傷害:{ attactValue.AttactValue}{Environment.NewLine}";
        }

        private void Player2Status()
        {
            lbPlayer2.Text = $"{player2.Name}({player2.Hp.ToString()})";
        }

        private void Player1Status()
        {
            lbPlayer1.Text = $"{player1.Name}({player1.Hp.ToString()})";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player1.Attact(player2);
            player2.Attact(player1);
        }
    }
}