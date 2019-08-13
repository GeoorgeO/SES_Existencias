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
                            conexion.Datos.Rows[x][1] = conexion.Datos.Rows[x][1].ToString().Trim();
                        }
                        else
                        {
                            conexion.Datos.Rows[x][1] = string.Empty;
                        }
                        

                        if (conexion.Datos.Rows[x][2].ToString() != string.Empty)
                        {
                            conexion.Datos.Rows[x][2] = desencriptar.Desencriptar(conexion.Datos.Rows[x][2].ToString().Trim());
                        }
                        else
                        {
                            conexion.Datos.Rows[x][2] = string.Empty;
                        }
                        if (conexion.Datos.Rows[x][3].ToString() != string.Empty)
                        {
                            conexion.Datos.Rows[x][3] = desencriptar.Desencriptar(conexion.Datos.Rows[x][3].ToString().Trim()   );
                        }
                        else
                        {
                            conexion.Datos.Rows[x][3] = string.Empty;
                        }
                        if (conexion.Datos.Rows[x][4].ToString() != string.Empty)
                        {
                            conexion.Datos.Rows[x][4] = desencriptar.Desencriptar(conexion.Datos.Rows[x][4].ToString().Trim());
                        }
                        else
                        {
                            conexion.Datos.Rows[x][4] = string.Empty;
                        }
                        if (conexion.Datos.Rows[x][5].ToString() != string.Empty)
                        {
                            conexion.Datos.Rows[x][5] = desencriptar.Desencriptar(conexion.Datos.Rows[x][5].ToString().Trim());
                        }
                        else
                        {
                            conexion.Datos.Rows[x][5] = string.Empty;
                        }
                        if (conexion.Datos.Rows[x][6].ToString() != string.Empty)
                        {
                            conexion.Datos.Rows[x][6] = conexion.Datos.Rows[x][6].ToString(); ;
                        }
                        else
                        {
                            conexion.Datos.Rows[x][6] = string.Empty;
                        }
                        if (conexion.Datos.Rows[x][7].ToString() != string.Empty)
                        {
                            conexion.Datos.Rows[x][7] = conexion.Datos.Rows[x][7].ToString(); ;
                        }
                        else
                        {
                            conexion.Datos.Rows[x][7] = string.Empty;
                        }
                        if (conexion.Datos.Rows[x][8].ToString() != string.Empty)
                        {
                            conexion.Datos.Rows[x][8] = conexion.Datos.Rows[x][8].ToString(); ;
                        }
                        else
                        {
                            conexion.Datos.Rows[x][8] = string.Empty;
                        }
                    }
                    tabla.DataSource = conexion.Datos;
                }
            }
        }
        private void recorrertabla()
        {
            int xRow = 0;
            string Cadena = string.Empty;

            conecta c = new conecta();

            for (int i = 0; i < gridView1.RowCount; i++)
            {

                xRow = gridView1.GetVisibleRowHandle(i);

                int valorregresado = 0;

                valorregresado = c.datosconexion(gridView1.GetRowCellValue(xRow, "ServerID").ToString(), gridView1.GetRowCellValue(xRow, "DataBaseID").ToString(), gridView1.GetRowCellValue(xRow, "UserID").ToString(), gridView1.GetRowCellValue(xRow, "PassID").ToString(), "select ArticuloCantidad from Articulo where ArticuloCodigo='"+ txtCodpro .Text.Trim()+ "'");

                if (valorregresado<0)
                {
                    gridView1.SetRowCellValue(xRow, gridView1.Columns[7],"No disponible" );
                    valorregresado = 0;
                }
                else
                {
                    gridView1.SetRowCellValue(xRow, gridView1.Columns[7],"En linea");
                }

                //c.datosconexion("JONOFRE-LAP\\LOCALSQLINS", "SES_EstocolmoV3", "sa", "inventumc762$");
                gridView1.SetRowCellValue(xRow, gridView1.Columns[6],valorregresado);
                

            }
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            recorrertabla();
        }
    }
}