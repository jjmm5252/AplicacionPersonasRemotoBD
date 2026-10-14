using Microsoft.Data.SqlClient;
using System;
using ClosedXML.Excel;
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

        //Funcion Eliminar
        public static bool Func_Eliminar(long id)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                string consulta = $"Delete from tbl_personas where ID = {id}";
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


        //FUNCION EDITAR
        public static bool Func_Editar(long id, string nombre, string telefono)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                string consulta = $"update tbl_personas Set Nombre = '{nombre}',Telefono = '{telefono}' where ID = {id}";
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


        //Exportarlo en excel
        public static bool Func_ExportalExcel()
        {
            DataTable dt = new DataTable();
            try
            {
                //parte de la consulta
                SqlConnection conexion = new SqlConnection(cadena);
                string consulta = "select * from tbl_personas";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                adaptador.Fill(dt);

                //parte del Excel
                XLWorkbook workbook = new XLWorkbook();
                var hoja = workbook.Worksheets.Add("hoja1");
                hoja.Range("A1:C1").Merge().Value = "Listado Personas";
                hoja.Range("A1:C1").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                hoja.Cell("A2").Value = "ID";
                hoja.Cell("B2").Value = "Nombre";
                hoja.Cell("C2").Value = "Telefono";
                hoja.Range("A2:C2").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                hoja.Range("A1:C2").Style.Font.Bold = true;

                int filaActual = 3;
                foreach (DataRow row in dt.Rows)
                {
                    hoja.Cell($"A{filaActual}").Value = Convert.ToInt64(row["ID"]);
                    hoja.Cell($"B{filaActual}").Value = row["Nombre"].ToString();
                    hoja.Cell($"C{filaActual}").Value = Convert.ToInt64(row["Telefono"]);

                    hoja.Cell($"A{filaActual}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    hoja.Cell($"B{filaActual}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    hoja.Cell($"C{filaActual}").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    filaActual++;
                }

                int ultimaFila = filaActual - 1;
                if (ultimaFila >= 2)
                {
                    var rangoTabla = hoja.Range($"A2:C{ultimaFila}");
                    rangoTabla.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    rangoTabla.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                }

                workbook.SaveAs(@"C:\Users\jmond\Desktop\PruebaExcel.xlsx");

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
