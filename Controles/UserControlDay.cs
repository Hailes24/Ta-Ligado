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
        public (byte dia, byte mes, short ano) data;
        public UserControlDay(byte day, byte month, short year)
        {
            InitializeComponent();
            data = (day, month, year);
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
            var varCor = this.BackColor;
            var varCorII = this.label1.ForeColor;
            var obj = (UserControlDay)sender;
            if (obj.BackColor.Name.Equals("White"))
                return;
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(PointToScreen(e.Location));
            else if (e.Button == MouseButtons.Left)
            {
                var form = Application.OpenForms["Main"] as Main;
                foreach (Control item in form.flowLayoutPanel1.Controls)
                {
                    var check = item.GetType().Equals(((UserControlDay)sender).GetType()) ? true : false;
                    if (check)
                    {
                        if (item.Equals(obj))
                        {
                            ((UserControlDay)sender).BackColor = varCorII;
                            ((UserControlDay)sender).label1.ForeColor = varCor;
                        }
                        else
                        {
                            item.BackColor = varCor;
                            item.Controls[0].ForeColor = varCorII;
                        }
                    }
                }
            }
        }

        private void eventoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
