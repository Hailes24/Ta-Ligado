using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaLigado.Views
{
    public partial class frmCadastrarEvento : XtraForm
    {
        private List<string> pessoasEnvolvidasList = new List<string>();
        private string imgSource;
        public frmCadastrarEvento()
        {
            InitializeComponent();
        }

        private void frmCadastrarEvento_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e) => this.Close();

        private void panel1_Click(object sender, EventArgs e) => panel1.BackgroundImage = panel1.BackgroundImage.Equals(Properties.Resources.icons8_partly_cloudy_day_32) ? Properties.Resources.icons8_night_32 : Properties.Resources.icons8_partly_cloudy_day_32;

        private void plusPessosEnvolvidas_Click(object sender, EventArgs e)
        {
            pessoasEnvolvidasList.Add(txtPessoasEnvolvidas.Text);
            txtPessoasEnvolvidas.Text = string.Empty;
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "*.jpeg|*.png";
            DialogResult dialogResult = dialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                imgSource = dialog.FileName;
                //pictureEdit1.Image = dialog.ph
            }
        }
    }
}