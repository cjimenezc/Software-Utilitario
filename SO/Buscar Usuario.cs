using SO.logica;
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
    public partial class Buscar_Usuario : Form
    {
        public Usuario dt = Autentica.dato;
        Autentica clase = new Autentica();

        public Buscar_Usuario()
        {
            InitializeComponent();
            
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //Buscar a los usuarios en la base de datos para ser mostrados 
            clase.BuscarUsu(dataGridViewBuscar, txt_usuario.Text);
            gbx_buscar.Visible = true;
            gbx_usuario.Visible = false;
            groupBox1.Visible = false;
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            //Buscar el historial del usuario para ser mostrado
            clase.BuscarHistorial(dgv_historial, txt_usu.Text);
            gbx_buscar.Visible = false;
            gbx_usuario.Visible = false;
            groupBox1.Visible = true;
            btn_TrabBorrar.Visible = false;
            btn_TrabModif.Visible = false;
        }

        private void dataGridViewBuscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //cuando el usuario hace click muestra los datos de la persona
            clase.usuario(Convert.ToString(dataGridViewBuscar.CurrentRow.Cells[0].Value.ToString()));
            gbx_buscar.Visible = false;
            gbx_usuario.Visible = true;
            txt_Nombre.Text = dt.nombre;
            txt_Apellido1.Text = dt.apellido1;
            txt_Apellido2.Text = dt.apellido2;
            if (dt.perfil == 1)
            {
                cbx_perfil.Text = "Administrador";
            }
            else
            {
                cbx_perfil.Text = "Usuario";
            }
            txt_usu.Text = dt.usuario;
        }

        private void btnAnterior_Click_1(object sender, EventArgs e)
        {
            gbx_usuario.Visible = true;
            groupBox1.Visible = false;
            btn_TrabBorrar.Visible = true;
            btn_TrabModif.Visible = true;
        }
    }
}
