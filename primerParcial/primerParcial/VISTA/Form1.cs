using primerParcial.DAO;
using primerParcial.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primerParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Carga();
            Clear();
        }

        void Clear()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDui.Clear();
            txtDireccion.Clear();
            txtTel.Clear();
            txtEmail.Clear();
            txtCargo.Clear();
        }

        void Carga()
        {
            dataGridView1.Rows.Clear();
            ClsDTbl_empleado cls = new ClsDTbl_empleado();
            List<Tbl_empleado> Lista = cls.CargarDatosDeEmpleado();

            foreach (var iteracion in Lista)
            {
                dataGridView1.Rows.Add(iteracion.Id_empleado, iteracion.Empl_nombre, iteracion.Empl_apellido, iteracion.Empl_DUI, iteracion.Empl_direccion, iteracion.Empl_tel, iteracion.Empl_email, iteracion.Empl_cargo);
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsDTbl_empleado cls = new ClsDTbl_empleado();
            Tbl_empleado Tbl_empleado = new Tbl_empleado();

            Tbl_empleado.Id_empleado = Convert.ToInt32(txtId.Text);

            cls.DeleteDatosUser(Tbl_empleado);
            Carga();
            Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Id_Empleado = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string Empl_nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string Empl_apellido = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string Empl_DUI = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string Empl_direccion = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string Empl_tel = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string Empl_email = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            string Empl_cargo = dataGridView1.CurrentRow.Cells[7].Value.ToString();


            txtId.Text = Id_Empleado;
            txtNombre.Text = Empl_nombre;
            txtApellido.Text = Empl_apellido;
            txtDui.Text = Empl_DUI;
            txtDireccion.Text = Empl_direccion;
            txtTel.Text = Empl_tel;
            txtEmail.Text = Empl_email;
            txtCargo.Text = Empl_cargo;
        }
    }
}
