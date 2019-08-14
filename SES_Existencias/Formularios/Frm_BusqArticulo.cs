using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CapaDeDatos;

namespace SES_Existencias
{
    public partial class Frm_BusqArticulo : DevExpress.XtraEditors.XtraForm
    {
        public string codigoArticulo;
        public string nombreArticulo;
        public string existenciaLocal;

        public Frm_BusqArticulo()
        {
            InitializeComponent();
        }

        private void sbBuscar_Click(object sender, EventArgs e)
        {
           
        }

       

        public void cargarArticulos()
        {
            try
            {
                ConexionesSucursalesExistencias conexion = new ConexionesSucursalesExistencias();


                conexion.MtdSeleccionarArticulo();
                if (conexion.Exito)
                {
                    if (conexion.Datos.Rows.Count > 0)
                    {
                        Tabla.DataSource = conexion.Datos;
                    }
                }
            }
            catch(Exception e)
            {

            }
            
        }

        

        private void Frm_BusqArticulo_Load(object sender, EventArgs e)
        {
           
            cargarArticulos();
        }

        private void Tabla_DoubleClick(object sender, EventArgs e)
        {
            DataRow renglon;
            renglon = gridview.GetDataRow(gridview.GetSelectedRows()[0]);
            codigoArticulo = renglon[0].ToString();
            nombreArticulo = renglon[1].ToString();
            existenciaLocal = renglon[2].ToString();
            this.Close();
        }

        
    }
}