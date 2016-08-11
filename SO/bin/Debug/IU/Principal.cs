﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SO
{
    public partial class Frm_Navegador : Form
    {
        public string usuario;
        public Frm_Navegador()
        {
          
            InitializeComponent();
            
            timer1.Start();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            pgb_RAM.Value = (int)(performanceCounter1.NextValue());
            lb_RAM.Text = pgb_RAM.Value.ToString()+ "%";
            pgb_CPU.Value = (int)(performanceCounter2.NextValue());
            lb_CPU.Text = pgb_CPU.Value.ToString()+"%";
            
        }

        private void Frm_Navegador_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txt_navegar.Text);
        }

        private void verProcesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Procesos FrmNav = new Procesos();
           FrmNav.Show();
        }

        private void pgb_RAM_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoUsuario FrmUsu = new NuevoUsuario();
            FrmUsu.Show();

        }

    
    }
}
