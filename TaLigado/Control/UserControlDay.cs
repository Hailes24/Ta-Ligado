using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaLigado.Model;
using TaLigado.Views;

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
        public UserControl setDay(byte day)
        {
            label1.Text = day.ToString();
            return this;
        }
        private void UserControlDay_MouseClick(object sender, MouseEventArgs e)
        {
            var varCor = this.BackColor;
            var varCorII = this.label1.ForeColor;
            var obj = (UserControlDay)sender;
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(PointToScreen(e.Location));
            else if (e.Button == MouseButtons.Left)
            {
                if (obj.BackColor.Name.Equals("White"))
                    return;
                var form = Application.OpenForms["Main"] as Main;
                foreach (Control item in form.flowLayoutPanel1.Controls)
                {
                    if (item.GetType().Equals(obj.GetType()))
                    {
                        if (item.Equals(obj))
                        {
                            obj.BackColor = varCorII;
                            obj.label1.ForeColor = varCor;
                            var date = (new DateTime(data.ano, data.mes, data.dia)).ToShortDateString();
                            var dados = (new EventoRepository()).GetTableEventoLIst(date);
                            if (dados.Count > 0)
                                notifyIcon1.ShowBalloonTip(2, (string)dados[0]["titulo"], (string)dados[0]["Descricao"], ToolTipIcon.Info);
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

        private void objectivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmCadastrarEvento()).ShowDialog();
        }
    }
}
