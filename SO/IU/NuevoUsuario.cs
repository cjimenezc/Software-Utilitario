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
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)

        {
            int perfil = 0;
            //verifica si el el que ingresa los datos selecciona administrador
            if (cbx_perfil.SelectedItem.ToString() == "Administrador")
            {
                perfil = 1; 
            }
            else
            {
                perfil = 2;
            }
            //Envia los datos a la clase autentica para ser almacenados 
            new Autentica().InsetUsu(txt_usuario.Text, txt_contrasena.Text,perfil, txt_nombre.Text, txt_apellido1.Text, txt_apellido2.Text);
        }

    }
}
