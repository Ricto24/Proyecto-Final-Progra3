using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Net.Configuration;
using System.ComponentModel.Design;

namespace Conexion
{
    public class Conexion
    {

        public string conection = "";
        public bool estado = false;

        public Conexion(string conn)
        {
            this.conection = conn;
        }//fin public conexion

        public void validarIngreso(string usuario,string contrasena)
        {
            try
            {
                SqlConnection Conection = new SqlConnection(this.conection);
                Conection.Open();
                SqlCommand cmd = new SqlCommand("",Conection);//lo que se va a insertar o guardar de la base de datos 
                cmd.Parameters.AddWithValue("", usuario);
                cmd.Parameters.AddWithValue("", contrasena);//entre las comillas van el nombre los datos
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows.Count == 1)
                {
                    if (dt.Rows[0][8].ToString() == "A")
                    {
                        MessageBox.Show("Bienvenido al Sistema" + dt.Rows[0][2]);
                        estado = true;
                        new Menu(dt.Rows[0][8].ToString(), dt.Rows[0][1].ToString(),dt.Rows[0][2].ToString(),dt.Rows[0][3].ToString(),dt.
                    }

                }


            }
        }//fin public void validarIngreso
    }//fin public class conexion
}//fin namespace
