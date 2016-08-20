using System;
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
            lb_RAM.Text = pgb_RAM.Value.ToString() + "%";// muestra la memoria ram consumida
            pgb_CPU.Value = (int)(performanceCounter2.NextValue());
            lb_CPU.Text = pgb_CPU.Value.ToString() + "%"; //el uso que se le esta dando a la cpu
        }
        private void Frm_Navegador_FormClosing(Object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("FormClosing Event");
        }
        private void Frm_Navegador_Load(object sender, EventArgs e)
        {

            //la primera pagina web que se muestra es google
            webBrowser1.Navigate("www.google.com");
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            //busca la pagina que se ingreso 
            webBrowser1.Navigate(txt_navegar.Text);
        }

        private void verProcesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Procesos FrmNav = new Procesos();
            //FrmNav.Show();
            new Procesos().Show();
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NuevoUsuario().Show();//muestra el formulario para agregar un
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            //regresa la pagina anterior 
            webBrowser1.GoBack();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //regresa lo que habia  adelante
            webBrowser1.GoForward();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //refresca la pagina 
            webBrowser1.Refresh();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            //imprime la pagina web
            webBrowser1.Print();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //Muesta la pagina web que se escriba en la caja de texto
            txt_navegar.Text = webBrowser1.Url.ToString();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new Buscar_Usuario().Show();
        }
    }
}