using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Escolar.Clases;

namespace Proyecto_Escolar
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public bool UsuarioLogueado = false;
        frmAlumnos falumnos = null;
        private void Menu_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
//            Datos.AbrirConexion();
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            if (login.logueado==true)
            {
                this.Show();
                UsuarioLogueado = true;
                lbEstado.Text = "Usuario: " + login.resultado.Substring(20);
            }
            else
            {
                this.Close();
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UsuarioLogueado==true)
            {
                DialogResult respuesta;
                respuesta = MessageBox.Show("Desea salir del sistema?","Confirme",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (respuesta==DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos F_Alumnos = new frmAlumnos();
            F_Alumnos = frmAlumnos.Instancia();
            F_Alumnos.MdiParent = this;
            F_Alumnos.Show();
        }

        private void altasBajasCambiosDeMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Materias F_Materias = new frm_Materias();
            F_Materias = frm_Materias.Instancia();
            F_Materias.MdiParent = this;
            F_Materias.Show();
        }
    }
}
