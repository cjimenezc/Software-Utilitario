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
    public partial class login : Form
    {
        Autentica log = new Autentica();
        public login()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            {
                if (txt_usuario.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese el Usuario ");
                }
                else if (txt_contraseña.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese la Contraseña ");
                }
                else

                    if (log.Autenticar(txt_usuario.Text, txt_contraseña.Text) != 0)
                    {

                        Frm_Navegador FrmPrincipal = new Frm_Navegador();
                        FrmPrincipal.Show();
                        FrmPrincipal.lb_usuario.Text = txt_usuario.Text;
                        this.Hide();
                      
                    }

                if (log.Autenticar(txt_usuario.Text, txt_contraseña.Text) == 0)
                {
                    MessageBox.Show("Usuario o Contraseña incorrecto ");
                    txt_contraseña.Text = "";
                    txt_usuario.Focus();

                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
