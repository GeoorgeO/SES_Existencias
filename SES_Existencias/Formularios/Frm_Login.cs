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
using DevExpress.XtraBars.Helpers;

namespace SES_Existencias
{
    public partial class Frm_Login : DevExpress.XtraEditors.XtraForm
    {
        string vIdUsuario = string.Empty;
        int vIdActivo = 0;
        public Boolean habilitado = true;
        private int pantalla;

        public Frm_Login(int pantalla)
        {
            InitializeComponent();
            this.pantalla = pantalla;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = XtraMessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (DialogResult == DialogResult.Yes)
            {
                Close();
            }
        }
        private void btnAcceso_Click(object sender, EventArgs e)
        {
            if (btnAcceso.Text == "Acceso")
            {
                if (txtUser.Text != string.Empty && txtPass.Text != string.Empty)
                {
                    Crypto claseencripta = new Crypto();
                    CLS_Usuario_Pantalla sLogin = new CLS_Usuario_Pantalla();

                    sLogin.c_codigo_usu = txtUser.Text.Trim();
                    sLogin.v_passwo_usu = txtPass.Text.Trim();

                    sLogin.MtdSeleccionarUsuarioLogin();
                    if (sLogin.Exito)
                    {
                        if (sLogin.Datos.Rows.Count > 0)
                        {
                            vIdUsuario = sLogin.Datos.Rows[0]["UsuariosId"].ToString();
                            if (sLogin.Datos.Rows[0]["UsuariosActivo"].ToString() == "A")
                            {
                                vIdActivo = 1;
                            }
                            else
                            {
                                vIdActivo = 0;
                            }
                          
                            MSRegistro RegIn = new MSRegistro();
                            
                            if (vIdActivo == 1)
                            {

                                if (Permisos(txtUser.Text.Trim(),pantalla))
                                {
                                    if (pantalla == 8)
                                    {
                                        Frm_Conexiones editconexion = new Frm_Conexiones();
                                        this.Hide();
                                        editconexion.ShowDialog();
                                    }
                                    else
                                    {
                                        Frm_ConexionesSucursales editconexion = new Frm_ConexionesSucursales();
                                        this.Hide();
                                        editconexion.ShowDialog();
                                    }
                                    this.Close();

                                }
                                else
                                {
                                    XtraMessageBox.Show("No tienes acceso a esta opción.");
                                }



                            }
                            else
                            {
                                XtraMessageBox.Show("Este usuario esta inactivo en el sistema");
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Usuario o Contraseña Incorrectos o El Usuario Esta Inactivo");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show(sLogin.Mensaje);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Faltan Datos por Capturar Usuario y/o Password");
                }
            }
        }

        private void pictureEdit1_DoubleClick(object sender, EventArgs e)
        {
            Frm_Conexiones frm = new Frm_Conexiones();
            frm.ShowDialog();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13 && txtUser.Text!=string.Empty)
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && txtPass.Text != string.Empty)
            {
                btnAcceso.Focus();
            }
        }
        
        private void Frm_Login_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
            MSRegistro RegOut = new MSRegistro();
            SkinForm.LookAndFeel.SetSkinStyle(RegOut.GetSetting("ConexionSQL", "Sking"));

            
           /* Crypto DesencriptarTexto = new Crypto();
            string valServer, valDB, valLogin, valPass;

            try
            {
                valServer = DesencriptarTexto.Desencriptar(RegOut.GetSetting("ConexionSQL", "Server"));
                valDB = DesencriptarTexto.Desencriptar(RegOut.GetSetting("ConexionSQL", "DBase"));
                valLogin = DesencriptarTexto.Desencriptar(RegOut.GetSetting("ConexionSQL", "User"));
                valPass = DesencriptarTexto.Desencriptar(RegOut.GetSetting("ConexionSQL", "Password"));
            }
            catch
            {
                valServer = string.Empty;
                valDB = string.Empty;
                valLogin = string.Empty;
                valPass = string.Empty;
            }*/

            

        }

        private void Frm_Login_Shown(object sender, EventArgs e)
        {
            txtUser.Focus();
            MSRegistro RegOut = new MSRegistro();
            SkinForm.LookAndFeel.SetSkinStyle(RegOut.GetSetting("ConexionSQL", "Sking"));
        }

        private bool Permisos(string usuariosLogin, int Pantalla)
        {
            Boolean Valor = false;
            CLS_Usuario_Pantalla sel = new CLS_Usuario_Pantalla();
            sel.c_codigo_usu = usuariosLogin;
            sel.InventarioPantallaId = Pantalla;
            sel.MtdSeleccionarUsuarioPantalla();
            if (sel.Exito)
            {
                if (sel.Datos.Rows.Count > 0)
                {
                    Valor = true;
                }
            }
            return Valor;
        }

    }
}