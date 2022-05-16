using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TaLigado.Controles;

namespace TaLigado
{
    public partial class Main : Form
    {
        private DateTime dataActual;
        private byte contMonth = 0;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dataActual = DateTime.Today;
            lblAno.Text = dataActual.Year.ToString();
            contMonth = (byte)dataActual.Month;
            lblMes.Text = GetMes((byte)dataActual.Month);
            Preencher(dataActual.Month);
            selecionarDataActual();
            checkTime();
        }
        private void Main_Load()
        {
            flowLayoutPanel1.Controls.Clear();
            dataActual = DateTime.Today;
            lblAno.Text = dataActual.Year.ToString();
            contMonth = (byte)dataActual.Month;
            lblMes.Text = GetMes((byte)dataActual.Month);
            Preencher(dataActual.Month);
            selecionarDataActual();
            checkTime();
        }
        private void selecionarDataActual()
        {
            var controlHoje = new UserControlDay((byte)dataActual.Day, (byte)dataActual.Month, (short)dataActual.Year);
            for (short i = 0; i < flowLayoutPanel1.Controls.Count; i++)
            {
                var check = flowLayoutPanel1.Controls[i].GetType().Equals((controlHoje.GetType())) ? true : false;
                if (check)
                {
                    var refer = (UserControlDay)flowLayoutPanel1.Controls[i];
                    if (refer.data == controlHoje.data)
                    {
                        var corAux = refer.BackColor;
                        refer.BackColor = refer.label1.ForeColor;
                        refer.label1.ForeColor = corAux;
                        refer.Select();
                        break;
                    }
                }
            }
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
        private void Preencher(int month)
        {
            var diasMes = DateTime.DaysInMonth(dataActual.Year, month);
            DateTime dataIncicioMes = new DateTime(dataActual.Year, month, 1);
            var diaSemana = Convert.ToInt32(dataIncicioMes.DayOfWeek.ToString("d")) + 1;
            for (byte i = 1; i < diaSemana; i++)
                flowLayoutPanel1.Controls.Add(new UserControlBlocoVacio());
            for (byte i = 1; i <= diasMes; i++)
                flowLayoutPanel1.Controls.Add(new UserControlDay(day: i, month: contMonth, year: (short)dataActual.Year).setDay(i));
        }
        private string GetMes(byte mes)
        {
            switch (mes)
            {
                case 1:return "JANEIRO";
                case 2:return "FEVEREIRO";
                case 3:return "MARÇO";
                case 4:return "ABRIL";
                case 5:return "MAIO";
                case 6:return "JUNHO";
                case 7:return "JULHO";
                case 8:return "AGOSTO";
                case 9:return "SETEMBRO";
                case 10:return "OCTUBRO";
                case 11:return "NOVEMBRO";
                case 12:return "DEZEMBRO";
                default: return "";
            }
        }
        private void nextMonth_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var monthFocado = ++contMonth;
            lblMes.Text = GetMes((byte)monthFocado);
            Preencher(monthFocado);
        }
        private void previusMonth_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var monthFocado = --contMonth;
            lblMes.Text = GetMes((byte)monthFocado);
            Preencher(monthFocado);
        }
        private void checkTime()
        {
            var hora = DateTime.Now.Hour;
            flowLayoutPanel2.BackgroundImage = (hora < 18 && hora > 5)? Properties.Resources.icons8_partly_cloudy_day_32: Properties.Resources.icons8_night_32;
        }
        private void button1_Click(object sender, EventArgs e) => Main_Load();
        private void pictureBox2_Click(object sender, EventArgs e) => Application.Exit();
        private void pictureBox4_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
        private void pictureBox3_Click(object sender, EventArgs e) => this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
    }
}
