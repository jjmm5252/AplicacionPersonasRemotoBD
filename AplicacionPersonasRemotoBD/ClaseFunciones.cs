using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
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
    }
}
