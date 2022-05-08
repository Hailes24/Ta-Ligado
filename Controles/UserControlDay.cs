using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaLigado.Controles
{
    public partial class UserControlDay : UserControl
    {
        public UserControlDay()
        {
            InitializeComponent();
        }

        private void UserControlDay_Load(object sender, EventArgs e)
        {
           
        }
        public UserControl setDay(byte day)
        {
            label1.Text = day.ToString();
            return this;
        }

        private void agendarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UserControlDay_DoubleClick(object sender, EventArgs e)
        {
            //this.Controls.Add(contextMenuStrip1);
            //contextMenuStrip1.Parent = this;
            //contextMenuStrip1.Show();
        }

        private void UserControlDay_Click(object sender, EventArgs e)
        {

        }

        private void UserControlDay_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(PointToScreen(e.Location));
            }
            else if (e.Button == MouseButtons.Left)
            {
                var cor = this.BackColor;
                this.BackColor = this.label1.ForeColor;
                this.label1.ForeColor = cor;
            }
        }
    }
}
