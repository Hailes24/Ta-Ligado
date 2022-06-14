
namespace TaLigado.Views
{
    partial class frmCadastrarEvento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarEvento));
            this.boxData = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.richTxtDescricao = new System.Windows.Forms.RichTextBox();
            this.txtTitulo = new DevExpress.XtraEditors.TextEdit();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPessoasEnvolvidas = new DevExpress.XtraEditors.TextEdit();
            this.plusPessosEnvolvidas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBoxFrequencia = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbHora = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLocalizacao = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.boxData.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPessoasEnvolvidas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxFrequencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalizacao.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // boxData
            // 
            this.boxData.EditValue = null;
            this.boxData.Location = new System.Drawing.Point(12, 232);
            this.boxData.Name = "boxData";
            this.boxData.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.boxData.Properties.Appearance.Options.UseBackColor = true;
            this.boxData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.boxData.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.boxData.Size = new System.Drawing.Size(194, 20);
            this.boxData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo:";
            // 
            // richTxtDescricao
            // 
            this.richTxtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.richTxtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTxtDescricao.Location = new System.Drawing.Point(12, 71);
            this.richTxtDescricao.Name = "richTxtDescricao";
            this.richTxtDescricao.Size = new System.Drawing.Size(194, 62);
            this.richTxtDescricao.TabIndex = 2;
            this.richTxtDescricao.Text = "";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(12, 31);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.txtTitulo.Properties.Appearance.Options.UseBackColor = true;
            this.txtTitulo.Size = new System.Drawing.Size(194, 20);
            this.txtTitulo.TabIndex = 3;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(135, 271);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.checkEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.checkEdit1.Properties.Caption = "Repetir";
            this.checkEdit1.Size = new System.Drawing.Size(75, 20);
            this.checkEdit1.TabIndex = 4;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureEdit1.Location = new System.Drawing.Point(12, 348);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(194, 61);
            this.pictureEdit1.TabIndex = 6;
            this.pictureEdit1.Click += new System.EventHandler(this.pictureEdit1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descrição:";
            // 
            // txtPessoasEnvolvidas
            // 
            this.txtPessoasEnvolvidas.Location = new System.Drawing.Point(12, 154);
            this.txtPessoasEnvolvidas.Name = "txtPessoasEnvolvidas";
            this.txtPessoasEnvolvidas.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.txtPessoasEnvolvidas.Properties.Appearance.Options.UseBackColor = true;
            this.txtPessoasEnvolvidas.Size = new System.Drawing.Size(158, 20);
            this.txtPessoasEnvolvidas.TabIndex = 8;
            // 
            // plusPessosEnvolvidas
            // 
            this.plusPessosEnvolvidas.BackColor = System.Drawing.Color.Transparent;
            this.plusPessosEnvolvidas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plusPessosEnvolvidas.BackgroundImage")));
            this.plusPessosEnvolvidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.plusPessosEnvolvidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plusPessosEnvolvidas.FlatAppearance.BorderSize = 0;
            this.plusPessosEnvolvidas.Location = new System.Drawing.Point(173, 151);
            this.plusPessosEnvolvidas.Margin = new System.Windows.Forms.Padding(0);
            this.plusPessosEnvolvidas.Name = "plusPessosEnvolvidas";
            this.plusPessosEnvolvidas.Size = new System.Drawing.Size(33, 24);
            this.plusPessosEnvolvidas.TabIndex = 11;
            this.plusPessosEnvolvidas.UseVisualStyleBackColor = false;
            this.plusPessosEnvolvidas.Click += new System.EventHandler(this.plusPessosEnvolvidas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pessoas envolvidas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Frequência:";
            // 
            // cmbBoxFrequencia
            // 
            this.cmbBoxFrequencia.Location = new System.Drawing.Point(12, 193);
            this.cmbBoxFrequencia.Name = "cmbBoxFrequencia";
            this.cmbBoxFrequencia.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.cmbBoxFrequencia.Properties.Appearance.Options.UseBackColor = true;
            this.cmbBoxFrequencia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBoxFrequencia.Properties.Items.AddRange(new object[] {
            "Não se repete",
            "Todos os dias",
            "Todas as semanas",
            "Todos os meses",
            "Todos os anos"});
            this.cmbBoxFrequencia.Size = new System.Drawing.Size(194, 20);
            this.cmbBoxFrequencia.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Data:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Hora:";
            // 
            // cmbHora
            // 
            this.cmbHora.Location = new System.Drawing.Point(12, 271);
            this.cmbHora.Name = "cmbHora";
            this.cmbHora.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.cmbHora.Properties.Appearance.Options.UseBackColor = true;
            this.cmbHora.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbHora.Properties.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbHora.Size = new System.Drawing.Size(81, 20);
            this.cmbHora.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::TaLigado.Properties.Resources.icons8_partly_cloudy_day_32;
            this.panel1.Location = new System.Drawing.Point(99, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 33);
            this.panel1.TabIndex = 18;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Localização:";
            // 
            // txtLocalizacao
            // 
            this.txtLocalizacao.Location = new System.Drawing.Point(12, 310);
            this.txtLocalizacao.Name = "txtLocalizacao";
            this.txtLocalizacao.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.txtLocalizacao.Properties.Appearance.Options.UseBackColor = true;
            this.txtLocalizacao.Size = new System.Drawing.Size(194, 20);
            this.txtLocalizacao.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Imagem:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(30, 415);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 22;
            this.simpleButton1.Text = "Confirmar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(111, 415);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 23;
            this.simpleButton2.Text = "Cancelar";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // frmCadastrarEvento
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 451);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLocalizacao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbHora);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBoxFrequencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plusPessosEnvolvidas);
            this.Controls.Add(this.txtPessoasEnvolvidas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.richTxtDescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmCadastrarEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastrarEvento";
            this.Load += new System.EventHandler(this.frmCadastrarEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boxData.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPessoasEnvolvidas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoxFrequencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocalizacao.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit boxData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTxtDescricao;
        private DevExpress.XtraEditors.TextEdit txtTitulo;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtPessoasEnvolvidas;
        private System.Windows.Forms.Button plusPessosEnvolvidas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBoxFrequencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.ComboBoxEdit cmbHora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtLocalizacao;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}