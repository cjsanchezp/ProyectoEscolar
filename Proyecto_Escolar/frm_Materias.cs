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
    public partial class frm_Materias : Form
    {
        public frm_Materias()
        {
            InitializeComponent();
        }
        private static frm_Materias frmInstancia = null;
        public static int Id_Materia;
        public static string materiaEncontrada;
        private void frm_Materias_Load(object sender, EventArgs e)
        {
            cargaMaterias();
        }
        //carga
        public void cargaMaterias()
        {
            txtId.Text = "Nuevo";
            txtMateria.Clear();
            txtMateria.Focus();
            DataTable tabla = Datos.ObtenerMaterias();
            dgvMateria.DataSource = tabla;
        }
        public static frm_Materias Instancia()
        {
            if (((frmInstancia == null) || (frmInstancia.IsDisposed == true)))
            {
                frmInstancia = new frm_Materias();
            }
            frmInstancia.BringToFront();
            return frmInstancia;
        }

        private void txtMateria_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo admitira letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void dgvMateria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMateria.DataSource==null)
            {
                return;
            }
            else
            {
                txtId.Text = dgvMateria.CurrentRow.Cells[0].Value.ToString();
                txtMateria.Text = dgvMateria.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtId.Text = "Nuevo";
            txtMateria.Clear();
            txtMateria.Focus();
        }
        //metodo validador de caracteres de cadena// public bool valida campo materia
        public bool validarCampo()
        {
            return (txtMateria.Text.Length > 5);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampo()==false)
            {
                MessageBox.Show("La Materia debe ser mayor a 5 caracteres,verificar por favor", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                materiaEncontrada = "";
                if (txtId.Text == "Nuevo")
                {
                    Id_Materia = 0;
                }
                else
                {
                    Id_Materia = int.Parse(txtId.Text);
                }
                // buscar dentro del gridview a traves de For Each
                foreach (DataGridViewRow Row in dgvMateria.Rows)
                {
                    int fila = Row.Index;
                    string valor = Row.Cells[1].Value.ToString();
                    if (valor==txtMateria.Text)
                    {
                        materiaEncontrada = valor;
                        //MessageBox.Show("La materia enconrada es " + valor);
                        dgvMateria.Rows[fila].Selected = true;
                    }
                }
                //Validamos la variable valor
                if (materiaEncontrada != "")
                {
                    DialogResult respuesta;
                    respuesta = MessageBox.Show("La Materia " + materiaEncontrada + "existe, ¿Desea actualizarla?", "Pregunta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.OK)
                    {
                        MessageBox.Show("Procedemos a Guardar");
                        cargaMaterias();

                    }
                    else
                    {
                        MessageBox.Show("Cancelamos la operacion");
                        cargaMaterias();
                    }
                }
                else
                {
                    MessageBox.Show("Procedemos a Guardar");
                    cargaMaterias();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
