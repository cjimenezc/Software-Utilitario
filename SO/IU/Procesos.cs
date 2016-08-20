using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SO
{
    public partial class Procesos : Form
    {
        public Procesos()
        {
            InitializeComponent();
            UpdateProcessList();
        }
        public void UpdateProcessList()
        {
            int celda = 0;
            int fila = 0;
            foreach (Process p in Process.GetProcesses())
            {
                dataGridView1.Rows.Add(p.ProcessName, p.SessionId, (p.WorkingSet64 / 1024));//agregar nombre proceso
                /*dataGridView1.Rows.Add ();// RAM del procesoo*/
                celda++;
                fila++;
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

            foreach (Process p in Process.GetProcesses())
            {
                String proceso = this.dataGridView1.CurrentCell.Value.ToString();
                if (p.ProcessName == proceso)
                {
                    p.Kill(); // elimina el proceso
                    MessageBox.Show("Proceso Eliminado ", "Eliminar", MessageBoxButtons.OK);
                }
            }
        } 
    }

}
