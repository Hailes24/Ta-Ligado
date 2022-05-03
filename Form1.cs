using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaLigado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += new Random().Next(1, 10);
            if (panel2.Width >= panel1.Width)
            {
                timer1.Stop();
                this.Hide();
                new Main().ShowDialog();
            }
            else if (panel2.Width == new Random().Next(16, 330))
                panel2.Width -= 35;
        }
        private void panel3_Click(object sender, EventArgs e) => Application.Exit(); 
    }
}
