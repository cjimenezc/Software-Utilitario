namespace SO
{
    partial class Frm_Navegador
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
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.performanceCounter2 = new System.Diagnostics.PerformanceCounter();
            this.label1 = new System.Windows.Forms.Label();
            this.pgb_RAM = new System.Windows.Forms.ProgressBar();
            this.lb_RAM = new System.Windows.Forms.Label();
            this.pgb_CPU = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.lb_CPU = new System.Windows.Forms.Label();
            this.txt_navegar = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProcesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anadirUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "Memoria";
            this.performanceCounter1.CounterName = "% de bytes confirmados en uso";
            // 
            // timer1
            // 
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // performanceCounter2
            // 
            this.performanceCounter2.CategoryName = "Procesador";
            this.performanceCounter2.CounterName = "% de tiempo de procesador";
            this.performanceCounter2.InstanceName = "_Total";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "RAM";
            // 
            // pgb_RAM
            // 
            this.pgb_RAM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pgb_RAM.Location = new System.Drawing.Point(584, 27);
            this.pgb_RAM.Name = "pgb_RAM";
            this.pgb_RAM.RightToLeftLayout = true;
            this.pgb_RAM.Size = new System.Drawing.Size(162, 16);
            this.pgb_RAM.TabIndex = 18;
            // 
            // lb_RAM
            // 
            this.lb_RAM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_RAM.AutoSize = true;
            this.lb_RAM.BackColor = System.Drawing.Color.Transparent;
            this.lb_RAM.Location = new System.Drawing.Point(752, 30);
            this.lb_RAM.Name = "lb_RAM";
            this.lb_RAM.Size = new System.Drawing.Size(0, 13);
            this.lb_RAM.TabIndex = 22;
            // 
            // pgb_CPU
            // 
            this.pgb_CPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pgb_CPU.Location = new System.Drawing.Point(584, 49);
            this.pgb_CPU.Name = "pgb_CPU";
            this.pgb_CPU.Size = new System.Drawing.Size(162, 16);
            this.pgb_CPU.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "CPU";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(2, 72);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(773, 367);
            this.webBrowser1.TabIndex = 8;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Buscar.Location = new System.Drawing.Point(466, 36);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 27);
            this.btn_Buscar.TabIndex = 25;
            this.btn_Buscar.Text = "BUSCAR";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // lb_CPU
            // 
            this.lb_CPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_CPU.AutoSize = true;
            this.lb_CPU.BackColor = System.Drawing.Color.Transparent;
            this.lb_CPU.Location = new System.Drawing.Point(752, 55);
            this.lb_CPU.Name = "lb_CPU";
            this.lb_CPU.Size = new System.Drawing.Size(0, 13);
            this.lb_CPU.TabIndex = 26;
            // 
            // txt_navegar
            // 
            this.txt_navegar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_navegar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_navegar.Location = new System.Drawing.Point(12, 38);
            this.txt_navegar.Name = "txt_navegar";
            this.txt_navegar.Size = new System.Drawing.Size(452, 26);
            this.txt_navegar.TabIndex = 27;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verProcesosToolStripMenuItem,
            this.anadirUsuariosToolStripMenuItem});
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.administrarToolStripMenuItem.Text = "Administrar";
            // 
            // verProcesosToolStripMenuItem
            // 
            this.verProcesosToolStripMenuItem.Name = "verProcesosToolStripMenuItem";
            this.verProcesosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verProcesosToolStripMenuItem.Text = "Ver procesos";
            this.verProcesosToolStripMenuItem.Click += new System.EventHandler(this.verProcesosToolStripMenuItem_Click);
            // 
            // anadirUsuariosToolStripMenuItem
            // 
            this.anadirUsuariosToolStripMenuItem.Name = "anadirUsuariosToolStripMenuItem";
            this.anadirUsuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.anadirUsuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // Frm_Navegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 439);
            this.Controls.Add(this.txt_navegar);
            this.Controls.Add(this.lb_CPU);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pgb_CPU);
            this.Controls.Add(this.pgb_RAM);
            this.Controls.Add(this.lb_RAM);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Navegador";
            this.Text = "Navegador";
            this.Load += new System.EventHandler(this.Frm_Navegador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        public System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Diagnostics.PerformanceCounter performanceCounter2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pgb_RAM;
        private System.Windows.Forms.Label lb_RAM;
        private System.Windows.Forms.ProgressBar pgb_CPU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label lb_CPU;
        private System.Windows.Forms.TextBox txt_navegar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verProcesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anadirUsuariosToolStripMenuItem;
    }
}

