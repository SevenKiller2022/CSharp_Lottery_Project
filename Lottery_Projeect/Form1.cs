using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Lottery_Projeect
{
    public partial class Form1 : Form
    {
        private readonly lotteryEntities player = new lotteryEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var username = email.Text.Trim();
            var password = pass.Text;
            var login = player.Players.FirstOrDefault(q => q.Username == username && q.Password == password);

            if (login!=null)
            {
                var id = login.id;
                HomeForm homeForm = new HomeForm(id);
                homeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fail to login");
                email.Clear();
                pass.Clear();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
