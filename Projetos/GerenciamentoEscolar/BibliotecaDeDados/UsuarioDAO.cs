using System;
using System.Data;
using System.Data.SqlClient;
using Models;
using System.Configuration;

namespace DataAccess
{
    public class UsuarioDAO
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable DLogin(Usuario obje)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", obje.nome);
                cmd.Parameters.AddWithValue("@senha", obje.senha);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return dt;
        }

        public DataTable D_BuscarUsuario(Usuario obje)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("buscar_usuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", "%" + obje.nome + "%");
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return dt;
        }

        public DataTable D_ListarUsuario(Usuario obje)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("listar_usuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return dt;
        }

        public DataTable D_ListarTipo(Usuario obje)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id_tipo, nome_tipo FROM tipo", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return dt;
        }

        public string D_MCrudUsuario(Usuario obje)
        {
            string mensagem = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("procedimento_usuario", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", obje.id > 0 ? (object)obje.id : DBNull.Value);
                cmd.Parameters.AddWithValue("@nome", obje.nome);
                cmd.Parameters.AddWithValue("@senha", string.IsNullOrEmpty(obje.senha) ? "senhapadrao" : obje.senha);
                cmd.Parameters.AddWithValue("@id_tipo", obje.id_tipo);
                cmd.Parameters.AddWithValue("@acao", obje.acao);

                SqlParameter paramMensagem = new SqlParameter("@mensagem", SqlDbType.VarChar, 100);
                paramMensagem.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(paramMensagem);

                cmd.ExecuteNonQuery();
                mensagem = paramMensagem.Value.ToString();
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return mensagem;
        }
    }
}