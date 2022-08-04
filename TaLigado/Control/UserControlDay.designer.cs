
namespace TaLigado.Controles
{
    partial class UserControlDay
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDay));
            this.label1 = new System.Windows.Forms.Label();
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
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.contextMenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendarToolStripMenuItem,
            this.limparEventosToolStripMenuItem,
            this.visualizarToolStripMenuItem,
            this.imprimirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
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
            this.agendarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agendarToolStripMenuItem.Text = "Novo";
            this.agendarToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // objectivoToolStripMenuItem
            // 
            this.objectivoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.objectivoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.objectivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("objectivoToolStripMenuItem.Image")));
            this.objectivoToolStripMenuItem.Name = "objectivoToolStripMenuItem";
            this.objectivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.objectivoToolStripMenuItem.Text = "Evento";
            this.objectivoToolStripMenuItem.Click += new System.EventHandler(this.objectivoToolStripMenuItem_Click);
            // 
            // eventoToolStripMenuItem
            // 
            this.eventoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.eventoToolStripMenuItem.Enabled = false;
            this.eventoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eventoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eventoToolStripMenuItem.Image")));
            this.eventoToolStripMenuItem.Name = "eventoToolStripMenuItem";
            this.eventoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eventoToolStripMenuItem.Text = "Lembrete";
            // 
            // lembreteToolStripMenuItem
            // 
            this.lembreteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.lembreteToolStripMenuItem.Enabled = false;
            this.lembreteToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.lembreteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lembreteToolStripMenuItem.Image")));
            this.lembreteToolStripMenuItem.Name = "lembreteToolStripMenuItem";
            this.lembreteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lembreteToolStripMenuItem.Text = "Objectivo";
            // 
            // tarefaToolStripMenuItem
            // 
            this.tarefaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.tarefaToolStripMenuItem.Enabled = false;
            this.tarefaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tarefaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tarefaToolStripMenuItem.Image")));
            this.tarefaToolStripMenuItem.Name = "tarefaToolStripMenuItem";
            this.tarefaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.limparEventosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.limparEventosToolStripMenuItem.Text = "Limpar";
            this.limparEventosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // todosEventosToolStripMenuItem
            // 
            this.todosEventosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.todosEventosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.todosEventosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("todosEventosToolStripMenuItem.Image")));
            this.todosEventosToolStripMenuItem.Name = "todosEventosToolStripMenuItem";
            this.todosEventosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.todosEventosToolStripMenuItem.Text = "Todos";
            // 
            // selecionarToolStripMenuItem
            // 
            this.selecionarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.selecionarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.selecionarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selecionarToolStripMenuItem.Image")));
            this.selecionarToolStripMenuItem.Name = "selecionarToolStripMenuItem";
            this.selecionarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selecionarToolStripMenuItem.Text = "Selecionar";
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.visualizarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visualizarToolStripMenuItem.Image")));
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // diaToolStripMenuItem
            // 
            this.diaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.diaToolStripMenuItem.Enabled = false;
            this.diaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.diaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("diaToolStripMenuItem.Image")));
            this.diaToolStripMenuItem.Name = "diaToolStripMenuItem";
            this.diaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.diaToolStripMenuItem.Text = "Diario";
            // 
            // mêsToolStripMenuItem
            // 
            this.mêsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.mêsToolStripMenuItem.Enabled = false;
            this.mêsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mêsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mêsToolStripMenuItem.Image")));
            this.mêsToolStripMenuItem.Name = "mêsToolStripMenuItem";
            this.mêsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mêsToolStripMenuItem.Text = "Semenal";
            // 
            // anoToolStripMenuItem
            // 
            this.anoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.anoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.anoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("anoToolStripMenuItem.Image")));
            this.anoToolStripMenuItem.Name = "anoToolStripMenuItem";
            this.anoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.anoToolStripMenuItem.Text = "Mensal";
            // 
            // anoToolStripMenuItem1
            // 
            this.anoToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.anoToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.anoToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("anoToolStripMenuItem1.Image")));
            this.anoToolStripMenuItem1.Name = "anoToolStripMenuItem1";
            this.anoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.anoToolStripMenuItem1.Text = "Anual";
            // 
            // UserControlDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.label1);
            this.Name = "UserControlDay";
            this.Size = new System.Drawing.Size(85, 42);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserControlDay_MouseClick);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objectivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lembreteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarefaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosEventosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selecionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mêsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anoToolStripMenuItem1;
    }
}
