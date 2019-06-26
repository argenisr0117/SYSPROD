using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TempSys
{
    public class clsManejador
    {
        public SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
        public SqlConnection conexion2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);

        public void Conectar()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        
        }

        public void Desconectar()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                conexion.Close();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
       }
        public void Conectar2()
        {
            try
            {
                if (conexion2.State == ConnectionState.Closed)
                    conexion2.Open();
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }
        public void Desconectar2()
        {
            try
            {
                if (conexion2.State == ConnectionState.Open)
                    conexion2.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public DataTable Listado(String NombreSP, List<clsParametros> lst)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            try
            {
                Conectar();
                da = new SqlDataAdapter(NombreSP, conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        da.SelectCommand.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                    }
                }
                da.Fill(dt);
                da.Dispose();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            Desconectar();
            return dt;
        }
        public DataTable Listado2(String NombreSP, List<clsParametros> lst)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            try
            {
                Conectar2();
                da = new SqlDataAdapter(NombreSP, conexion2);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        da.SelectCommand.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                    }
                }
                da.Fill(dt);
                da.Dispose();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            Desconectar2();
            return dt;
        }

        public void EjecutarSP(String NombreSP, ref List<clsParametros> lst)
        {
            SqlCommand cmd;
            try
            {
                Conectar();
                cmd = new SqlCommand(NombreSP, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].Direccion == ParameterDirection.Input)
                            cmd.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        if (lst[i].Direccion == ParameterDirection.Output)
                            cmd.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output;
                    }
                    cmd.ExecuteNonQuery();
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (cmd.Parameters[i].Direction == ParameterDirection.Output)
                            lst[i].Valor = cmd.Parameters[i].Value;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            Desconectar();
        }
    }
}
