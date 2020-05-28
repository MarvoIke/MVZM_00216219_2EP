using System;
using System.Windows.Forms;

namespace parcialDos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Timer timer = new Timer();

        private void pnlF1_Paint(object sender, PaintEventArgs e)
        {
            timer.Interval = 3000;
            timer.Tick += timer_Tick;
            timer.Start();
            lblChar1.Show();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            Comenzar();
        }
        private void Comenzar()
        {
            timer.Stop();
            Hide();
            Form2 next = new Form2();
            next.ShowDialog();
            Close();
        }
    }
}