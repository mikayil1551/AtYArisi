using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
        public object MainForm { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            AtDurumDegistir(true);
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(102,102,102);
            AtDurumDegistir(false);

        }
        void AtDurumDegistir(bool durum,PictureBox at)
        {
            atAlber5.Enabled = atGolgeYeli4.Enabled = atYagiz2.Enabled
                = atRuzgarGulu1.Enabled = atPoyraz3.Enabled = durum;
            at.Enabled = false;
        }
        void AtDurumDegistir(bool durum)
        {
            atAlber5.Enabled = atGolgeYeli4.Enabled = atYagiz2.Enabled
               = atRuzgarGulu1.Enabled = atPoyraz3.Enabled = durum;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            atYagiz2.Left += rnd.Next(1, 5);
            atPoyraz3.Left += rnd.Next(1, 5);
            atRuzgarGulu1.Left += rnd.Next(1, 5);
            atGolgeYeli4.Left += rnd.Next(1, 5);
            atAlber5.Left += rnd.Next(1, 5);

            KimKazandi(atRuzgarGulu1);
            KimKazandi(atGolgeYeli4);
            KimKazandi(atPoyraz3);
            KimKazandi(atAlber5);
            KimKazandi(atYagiz2);
           
        }
        void KimKazandi (PictureBox kazanan)
        {
            if (kazanan.Right - 17 >= lblFinish.Left)
            {
                timer1.Stop();
                AtDurumDegistir(false, kazanan);
                MessageBox.Show(kazanan.Name);
            }
        }
    }
}
