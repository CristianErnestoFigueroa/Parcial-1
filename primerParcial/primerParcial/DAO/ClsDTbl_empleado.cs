using primerParcial.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primerParcial.DAO
{
    class ClsDTbl_empleado
    {
        public List<Tbl_empleado> CargarDatosDeEmpleado()
        {
            List<Tbl_empleado> Lista;


            using (EMPLEADOEntities db = new EMPLEADOEntities())
            {
                Lista = db.Tbl_empleado.ToList();
            }
            return Lista;
        }

        public void DeleteDatosUser(Tbl_empleado Tbl_empleado)
        {
            try
            {
                using (EMPLEADOEntities db = new EMPLEADOEntities())
                {
                    Tbl_empleado = db.Tbl_empleado.Find(Tbl_empleado.Id_empleado);
                    db.Tbl_empleado.Remove(Tbl_empleado);
                    db.SaveChanges();
                    MessageBox.Show("Removido");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
    }
}
