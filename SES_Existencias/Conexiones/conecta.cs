using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SES_Existencias
{
    class conecta
    {
        public int datosconexion(string servidor,string basededatos,string usuario, string contrasena,string consulta)
        {
            SqlConnection conexion = new SqlConnection("Data Source = "+ servidor + ";  Database="+ basededatos + "; User ID = "+ usuario + "; Password="+ contrasena + "; Connection Timeout=8");
            try
            {
                
                conexion.Open();
                Console.WriteLine("State: {0}", conexion.State);
                Console.WriteLine("ConnectionTimeout: {0}",
                    conexion.ConnectionTimeout);
            }
            catch (Exception e)
            {
                //XtraMessageBox.Show(e.Message,"Error de conexion" );
                return -1;

            }

            try
            {
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    
                    return Convert.ToInt32(Convert.ToString(dr["ArticuloCantidad"]));
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception e)
            {
                //XtraMessageBox.Show(e.Message, "Error de al consultar");
                return -1;

            }
            
            conexion.Close();
        }
       
        

    }
}
