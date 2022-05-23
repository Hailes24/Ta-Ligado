
namespace TaLigado.Views
{
    partial class XtraForm1
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::TaLigado.SplashScreen1), true, false, true);
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm1));
            this.calendarControl1 = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lembreteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarefaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosEventosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selecionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mêsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 40;
            // 
            // calendarControl1
            // 
            this.calendarControl1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.calendarControl1.Location = new System.Drawing.Point(441, 0);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.Size = new System.Drawing.Size(281, 475);
            this.calendarControl1.TabIndex = 0;
            this.calendarControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.calendarControl1_MouseClick);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 275);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(441, 200);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            pieSeriesLabel1.BackColor = System.Drawing.Color.Transparent;
            pieSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
            series1.Label = pieSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Name = "Series 1";
            series1.View = pieSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(441, 275);
            this.chartControl1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.contextMenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarToolStripMenuItem,
            this.limparEventosToolStripMenuItem,
            this.visualizarToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 92);
            // 
            // agendarToolStripMenuItem
            // 
            this.agendarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objectivoToolStripMenuItem,
            this.eventoToolStripMenuItem,
            this.lembreteToolStripMenuItem,
            this.tarefaToolStripMenuItem});
            this.agendarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.agendarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agendarToolStripMenuItem.Image")));
            this.agendarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.agendarToolStripMenuItem.Name = "agendarToolStripMenuItem";
            this.agendarToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.agendarToolStripMenuItem.Text = "Novo";
            this.agendarToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // objectivoToolStripMenuItem
            // 
            this.objectivoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.objectivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.objectivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("objectivoToolStripMenuItem.Image")));
            this.objectivoToolStripMenuItem.Name = "objectivoToolStripMenuItem";
            this.objectivoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.objectivoToolStripMenuItem.Text = "Evento";
            // 
            // eventoToolStripMenuItem
            // 
            this.eventoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.eventoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eventoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eventoToolStripMenuItem.Image")));
            this.eventoToolStripMenuItem.Name = "eventoToolStripMenuItem";
            this.eventoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eventoToolStripMenuItem.Text = "Lembrete";
            // 
            // lembreteToolStripMenuItem
            // 
            this.lembreteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lembreteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.lembreteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lembreteToolStripMenuItem.Image")));
            this.lembreteToolStripMenuItem.Name = "lembreteToolStripMenuItem";
            this.lembreteToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.lembreteToolStripMenuItem.Text = "Objectivo";
            // 
            // tarefaToolStripMenuItem
            // 
            this.tarefaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tarefaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tarefaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tarefaToolStripMenuItem.Image")));
            this.tarefaToolStripMenuItem.Name = "tarefaToolStripMenuItem";
            this.tarefaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.tarefaToolStripMenuItem.Text = "Tarefa";
            // 
            // limparEventosToolStripMenuItem
            // 
            this.limparEventosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosEventosToolStripMenuItem,
            this.selecionarToolStripMenuItem});
            this.limparEventosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.limparEventosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("limparEventosToolStripMenuItem.Image")));
            this.limparEventosToolStripMenuItem.Name = "limparEventosToolStripMenuItem";
            this.limparEventosToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.limparEventosToolStripMenuItem.Text = "Limpar";
            this.limparEventosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // todosEventosToolStripMenuItem
            // 
            this.todosEventosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.todosEventosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.todosEventosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("todosEventosToolStripMenuItem.Image")));
            this.todosEventosToolStripMenuItem.Name = "todosEventosToolStripMenuItem";
            this.todosEventosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.todosEventosToolStripMenuItem.Text = "Todos";
            // 
            // selecionarToolStripMenuItem
            // 
            this.selecionarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.selecionarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.selecionarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selecionarToolStripMenuItem.Image")));
            this.selecionarToolStripMenuItem.Name = "selecionarToolStripMenuItem";
            this.selecionarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.selecionarToolStripMenuItem.Text = "Selecionar";
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.visualizarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visualizarToolStripMenuItem.Image")));
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            this.visualizarToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diaToolStripMenuItem,
            this.mêsToolStripMenuItem,
            this.anoToolStripMenuItem,
            this.anoToolStripMenuItem1});
            this.imprimirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.imprimirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripMenuItem.Image")));
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // diaToolStripMenuItem
            // 
            this.diaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.diaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.diaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("diaToolStripMenuItem.Image")));
            this.diaToolStripMenuItem.Name = "diaToolStripMenuItem";
            this.diaToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.diaToolStripMenuItem.Text = "Diario";
            // 
            // mêsToolStripMenuItem
            // 
            this.mêsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.mêsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mêsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mêsToolStripMenuItem.Image")));
            this.mêsToolStripMenuItem.Name = "mêsToolStripMenuItem";
            this.mêsToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mêsToolStripMenuItem.Text = "Semenal";
            // 
            // anoToolStripMenuItem
            // 
            this.anoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.anoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.anoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("anoToolStripMenuItem.Image")));
            this.anoToolStripMenuItem.Name = "anoToolStripMenuItem";
            this.anoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.anoToolStripMenuItem.Text = "Mensal";
            // 
            // anoToolStripMenuItem1
            // 
            this.anoToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.anoToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.anoToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("anoToolStripMenuItem1.Image")));
            this.anoToolStripMenuItem1.Name = "anoToolStripMenuItem1";
            this.anoToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.anoToolStripMenuItem1.Text = "Anual";
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(722, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 475);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(722, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 475);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(722, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 475);
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 475);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.calendarControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            this.Load += new System.EventHandler(this.XtraForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objectivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lembreteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarefaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selecionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anoToolStripMenuItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}