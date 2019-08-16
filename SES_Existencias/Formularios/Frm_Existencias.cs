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
using DevExpress.XtraSplashScreen;

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
            Frm_Login login = new Frm_Login(8);
            login.ShowDialog();
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
            int suc;
            suc = CargarComboSucursales();
            if (suc >= 0)
            {
                conexion.SucursalesId = suc;
            }
            
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
                MensajeCargando(1);
                xRow = gridView1.GetVisibleRowHandle(i);

                int valorregresado = 0;

                valorregresado = c.datosconexion(gridView1.GetRowCellValue(xRow, "ServerID").ToString(), gridView1.GetRowCellValue(xRow, "DataBaseID").ToString(), gridView1.GetRowCellValue(xRow, "UserID").ToString(), gridView1.GetRowCellValue(xRow, "PassID").ToString(), "select ArticuloCantidad from Articulo where ArticuloCodigo='"+ txtCodpro .Text.Trim()+ "'");

               

                if (valorregresado < 0)
                {
                    gridView1.SetRowCellValue(xRow, gridView1.Columns[7], "No disponible");
                    gridView1.SetRowCellValue(xRow, gridView1.Columns[6], null);
                }
                else
                {
                    gridView1.SetRowCellValue(xRow, gridView1.Columns[7], "En linea");
                    gridView1.SetRowCellValue(xRow, gridView1.Columns[6], valorregresado);
                }
                //c.datosconexion("JONOFRE-LAP\\LOCALSQLINS", "SES_EstocolmoV3", "sa", "inventumc762$");

                MensajeCargando(2);

            }
           
        }

        private void limpiartablaestatus()
        {
            int renglon = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                renglon= gridView1.GetVisibleRowHandle(i);
                gridView1.SetRowCellValue(renglon, gridView1.Columns[7], "");
                gridView1.SetRowCellValue(renglon, gridView1.Columns[6], null);
            }
        }

        private int CargarComboSucursales()
        {
            MSRegistro RegOut = new MSRegistro();
            Crypto DesencriptarTexto = new Crypto();
           
                return  Convert.ToInt32(DesencriptarTexto.Desencriptar(RegOut.GetSetting("ConexionSQL", "Sucursal")));
               
             
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
            limpiartablaestatus();
            if (txtCodpro.Text != String.Empty && lNomArticulo.Text!=String.Empty)
            {
                recorrertabla();
            }
            
            
        }

        public void MensajeCargando(int opcion)
        {
            if (opcion == 1)
            {
                SplashScreenManager.ShowForm(this, typeof(Frm_CargandoConsulta), true, true, false);
                SplashScreenManager.Default.SetWaitFormCaption("Procesando...");
                SplashScreenManager.Default.SetWaitFormDescription("Espere por favor...");
            }
            else
            {
                try
                {
                    SplashScreenManager.CloseForm();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
            }
        }

        private void cargarArticuloId()
        {
            ConexionesSucursalesExistencias conexion = new ConexionesSucursalesExistencias();

            conexion.Codigo = txtCodpro.Text.Trim();
            conexion.MtdSeleccionarArticuloId();
            if (conexion.Exito)
            {
                if (conexion.Datos.Rows.Count > 0)
                {
                    if (conexion.Datos.Rows[0][1].ToString() != String.Empty)
                    {
                        lNomArticulo.Text = conexion.Datos.Rows[0][1].ToString();
                    }
                }
            }
        }

        private void sbCodProducto_Click(object sender, EventArgs e)
        {
            Frm_BusqArticulo BusArt = new Frm_BusqArticulo();

            BusArt.ShowDialog();
            txtCodpro.Text = BusArt.codigoArticulo;
            lNomArticulo.Text = BusArt.nombreArticulo;
            lexislocal.Text = BusArt.existenciaLocal;
        }

        private void sbConRemotas_Click(object sender, EventArgs e)
        {
            Frm_Login login = new Frm_Login(9);
            login.ShowDialog();
        }
        private void llenaarticulo(string Codigo,string Articulo){
            txtCodpro.Text = Codigo;
            lNomArticulo.Text = Articulo;
        }

        private void txtCodpro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                if (txtCodpro.Text==String.Empty)
                {
                    sbCodProducto.PerformClick();
                }
                else
                {
                    cargarArticuloId();
                }
            }
        }

        private void txtCodpro_TextChanged(object sender, EventArgs e)
        {
            lNomArticulo.Text = String.Empty;
        }
    }
}