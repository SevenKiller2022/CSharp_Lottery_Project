using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Projeect
{
    public partial class HomeForm : Form
    {
        SoundPlayer soundPlayer = new SoundPlayer();

        private readonly lotteryEntities Player = new lotteryEntities();
        public int ID;
        public HomeForm(int id)
        {
            InitializeComponent();
            ID = id;
       
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
          
            soundPlayer.SoundLocation = "C://Users//Hong Rakchhai//Desktop//C# Projects//assignment//Lottery_Projeect//VANNDA - ជំពូកទី១ (Chapter I) - Live Performance.wav";
            soundPlayer.Play();

            var Id =ID ;
            var player = Player.Players.FirstOrDefault(q => q.id == ID);
            txtUsername.Text = player.Name;
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            soundPlayer.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            soundPlayer.Play();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var Id = ID;
            Form2 form2 = new Form2(Id);
            form2.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var Id = ID;
            Form2 form2 = new Form2(Id);
            form2.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
