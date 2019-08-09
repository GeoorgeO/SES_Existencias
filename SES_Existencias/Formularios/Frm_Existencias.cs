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
    public partial class Frm_Existencias : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Existencias()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Frm_Conexiones editconexion = new Frm_Conexiones();
            editconexion.ShowDialog();
        }

        private void Frm_Existencias_Load(object sender, EventArgs e)
        {
            //gridView1.OptionsBehavior.Editable = false;
            //gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            //gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            //CargarSucursales(null);
            CargarConexionesSucursalesExistencias();
        }

        private void CargarConexionesSucursalesExistencias()
        {
            ConexionesSucursalesExistencias conexion = new ConexionesSucursalesExistencias();
            Crypto desencriptar = new Crypto();
            conexion.MtdSeleccionarConexionesSucursales();
            if (conexion.Exito)
            {
                if (conexion.Datos.Rows.Count > 0)
                {
                    for (int x = 0; x < conexion.Datos.Rows.Count; x++)
                    {
                        if (conexion.Datos.Rows[x][0].ToString() != string.Empty)
                        {
                            conexion.Datos.Rows[x][0] = conexion.Datos.Rows[x][0].ToString(); ;
                        }
                        else
                        {
                            conexion.Datos.Rows[x][0] = string.Empty;
                        }
                        if (conexion.Datos.Rows[x][1].ToString() != string.Empty)
                        {
                            conexion.Datos.Rows[x][1] = conexion.Datos.Rows[x][1].ToString();
                        }
                        else
                        {
                            conexion.Datos.Rows[x][1] = string.Empty;
                        }
                        

                        if (conexion.Datos.Rows[x][2].ToString() != string.Empty)
                        {
                            conexion.Datos.Rows[x][2] =conexion.Datos.Rows[x][2].ToString();
                        }
                        else
                        {
                            conexion.Datos.Rows[x][2] = string.Empty;
                        }
                        if (conexion.Datos.Rows[x][3].ToString() != string.Empty)
                        {
                            conexion.Datos.Rows[x][3] = desencriptar.Desencriptar(conexion.Datos.Rows[x][3].ToString());
                        }
                        else
                        {
                            conexion.Datos.Rows[x][3] = string.Empty;
                        }
                        if (conexion.Datos.Rows[x][4].ToString() != string.Empty)
                        {
                            conexion.Datos.Rows[x][4] = conexion.Datos.Rows[x][4].ToString();
                        }
                        else
                        {
                            conexion.Datos.Rows[x][4] = string.Empty;
                        }
                    }
                    tabla.DataSource = conexion.Datos;
                }
            }
        }
    }
}