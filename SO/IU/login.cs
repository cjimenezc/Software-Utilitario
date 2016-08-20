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
                if (txt_usuario.Text.Trim() == "")//verifica si ingreso el usuario 
                {
                    MessageBox.Show("Ingrese el Usuario ");
                }
                else if (txt_contraseña.Text.Trim() == "")//verifica si ingreso el usuario 
                {
                    MessageBox.Show("Ingrese la Contraseña ");
                }
                else
                    /*Verifica si la cotraseña y usuario es correcta y si es correcto 
                     envia al usuario al menu principal*/
                    if (log.Autenticar(txt_usuario.Text, txt_contraseña.Text) != 0)
                    {
                        Frm_Navegador FrmPrincipal = new Frm_Navegador();
                        FrmPrincipal.Show();
                        FrmPrincipal.lb_usuario.Text = txt_usuario.Text;
                        if (new Autentica().PermisosRol(txt_usuario.Text) != 0)
                        {
                            FrmPrincipal.anadirUsuariosToolStripMenuItem.Visible = true;
                        }
                        log.Historial(txt_usuario.Text);
                        this.Hide();

                    }
                if (log.Autenticar(txt_usuario.Text, txt_contraseña.Text) == 0)//Verifica si la cotraseña no es correcta
                {
                    MessageBox.Show("Usuario o Contraseña incorrecto ");
                    txt_contraseña.Text = "";//limpia la caja de texto 
                    txt_usuario.Focus();//pone el focus en la caja de texto de usuario
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
