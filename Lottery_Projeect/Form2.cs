using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Projeect
{
    public partial class Form2 : Form
    {
        private readonly lotteryEntities Player =new lotteryEntities();
        public int ID;
        public Form2(int id)
        {
            InitializeComponent();
            ID = id;  
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            var player = Player.Players.FirstOrDefault(q=>q.id==ID);
            lbUsername.Text = player.Name;
            lbBalance.Text = player.Balance.ToString();
        }
        public void refresh(int id)
        {
            var player = Player.Players.FirstOrDefault(q => q.id == ID);
            lbBalance.Text = player.Balance.ToString();
        }
        int number1, number2, number3, number4, number5, number6;
        private void start_Click(object sender, EventArgs e)
        {
           timer1.Enabled= true;
            timer2.Enabled= true;
            timer3.Enabled= true;
            timer4.Enabled= true;
            timer5.Enabled= true;
            timer6.Enabled= true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            Random rand1 = new Random();
            number1 = rand1.Next(1, 3);
            n1.Text = Convert.ToString(number1);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            Random rand2 = new Random();
            number2 = rand2.Next(1, 3);
            n2.Text = Convert.ToString(number2);
        }

        private void lbUsername_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
          
            Random rand3 = new Random();
            number3 = rand3.Next(1, 3);
            n3.Text = Convert.ToString(number3);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
          
            Random rand4 = new Random();
            number4 = rand4.Next(1, 3);
            n4.Text = Convert.ToString(number4);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            Random rand5 = new Random();
            number5 = rand5.Next(1, 3);
            n5.Text = Convert.ToString(number5);
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
          
            Random rand6 = new Random();
            number6 = rand6.Next(1, 3);
            n6.Text = Convert.ToString(number6);
        }

        private void stop_Click(object sender, EventArgs e)
        {
            var player = Player.Players.FirstOrDefault(q => q.id == ID);
            decimal balance=decimal.Parse(lbBalance.Text);
            decimal bet = decimal.Parse(tbbet.Text);
            timer1.Enabled= false; timer2.Enabled = false;timer3.Enabled = false; timer4.Enabled = false;timer5.Enabled= false;timer6.Enabled= false;
            textBox1.Text = Convert.ToString(number1);
            textBox2.Text = Convert.ToString(number2);
            textBox3.Text = Convert.ToString(number3);
            textBox4.Text = Convert.ToString(number4);
            textBox5.Text = Convert.ToString(number5);
            textBox6.Text = Convert.ToString(number6);
            var num1= Convert.ToString(number1);
            var num2 = Convert.ToString(number2);
            var num3 = Convert.ToString(number3);
            var num4 = Convert.ToString(number4);
            var num5 = Convert.ToString(number5);
            var num6 = Convert.ToString(number6);
            var pnum1 = tbbet.Text.ToString();
            var pnum2 = pNum2.Text.ToString();
            var pnum3 = pNum3.Text.ToString();
            var pnum4 = pNum4.Text.ToString();
            var pnum5 = pNum5.Text.ToString();
            var pnum6 = pNum6.Text.ToString();
            int win = 0;
            if (num1 == pnum1)
            {
                win++;
            }
            if (num2 == pnum2)
            {
                win++;
            }
            if (num3 == pnum3)
            {
                win++;
            }
            if (num4 == pnum4)
            {
                win++;
            }
            if (num5 == pnum5)
            {
                win++;
            }
            if (num6 == pnum6)
            {
                win++;
            }
            if (win == 3)
            {
                //200%
                decimal wining = balance + (bet*2);
                player.Balance=wining;
                Player.SaveChanges();
                refresh(ID);
                MessageBox.Show("You Win small");
            }
            else if (win == 4)
            {
                //400%
                decimal wining = balance + (bet * 4);
                player.Balance = wining;
                Player.SaveChanges();
                refresh(ID);
                MessageBox.Show("You mediem" + win);
            }
            else if (win == 5)
            {
                //600%
                decimal wining = balance + (bet * 6);
                player.Balance = wining;
                Player.SaveChanges();
                refresh(ID);
                MessageBox.Show("You big" + win);
            }
            else if (win==6)
            {
                //2000%
                decimal wining = balance + (bet * 20);
                player.Balance = wining;
                Player.SaveChanges();
                refresh(ID);
                MessageBox.Show("You JACKPOT" + win);
            }
            else if (win <= 2)
            {
                decimal realB = balance-bet ;
                player.Balance = realB;
                Player.SaveChanges();
                refresh(ID);
            }

        }
    }
}
