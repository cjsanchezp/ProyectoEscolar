using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Escolar
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }
        private static frmAlumnos frmInstancia =null;
        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static frmAlumnos Instancia()
        {
            if (((frmInstancia == null)||(frmInstancia.IsDisposed == true)))
            {
                frmInstancia = new frmAlumnos();
            }
            frmInstancia.BringToFront();
            return frmInstancia;
        }

        
    }
}
