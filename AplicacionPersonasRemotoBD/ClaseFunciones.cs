using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AplicacionPersonasRemotoBD
{
    internal class ClaseFunciones
    {
        public static string cadena = "workstation id=BDPersonas_Blad.mssql.somee.com;packet size=4096;user id=jjmm5252_SQLLogin_2;pwd=o2883kj32a;data source=BDPersonas_Blad.mssql.somee.com;persist security info=False;initial catalog=BDPersonas_Blad;TrustServerCertificate=True";

        public static string excepcion = "";

        //funcion conectar
        public static bool Funcion_Conectar()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                conexion.Close();
                return true;
            }
            catch(Exception ex)
            {
                excepcion = ex.ToString();
                return false;
            }
        }

        public static DataTable Func_TraerDatos()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                string consulta = "select * from tbl_personas";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta,conexion);
                //ejecuto el adaptador 
                adaptador.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                excepcion = ex.ToString();
                return dt;
            }
        }

        public static bool Func_Insertar(long id,string nombre,string telefono)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                string consulta = $"insert into tbl_personas values({id},'{nombre}','{telefono}')";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                //ejecuto el adaptador 
                adaptador.Fill(dt);
                return true;
            }
            catch (Exception ex)
            {
                excepcion = ex.ToString();
                return false;
            }
        }
    }
}
