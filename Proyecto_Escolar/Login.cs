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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public bool logueado = false;
        public string resultado;
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        public void IniciarSesion()
        {
            resultado = Datos.IniciarSesion(txtnombre.Text, txtcontraseña.Text);
            if (resultado != "")
            {
                logueado = true;
                MessageBox.Show(resultado, "mensaje", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Acceso Denegado", "Error", MessageBoxButtons.OK);
                txtnombre.Text = "";
                txtcontraseña.Text = "";
                txtnombre.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtcontraseña.Focus();
            }
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                IniciarSesion();
            }
        }
    }
}
