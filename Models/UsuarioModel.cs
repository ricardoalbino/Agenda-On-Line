using Agenda_Online.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Agenda_Online.Models
{
    public class UsuarioModel
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }



        public void salvar(UsuarioModel usuarioModel)
        {
            string sql = "INSERT INTO USUARIO (nome, email, senha) VALUES(@nome, @email, @senha)";

            SqlCommand cmd = new SqlCommand(sql, ConexaoBD.obterConexao());

            cmd.Parameters.AddWithValue("@nome", usuarioModel.nome);
            cmd.Parameters.AddWithValue("@email", usuarioModel.email);
            cmd.Parameters.AddWithValue("@senha", usuarioModel.senha);
            cmd.ExecuteNonQuery();

            ConexaoBD.fecharConexao();


        }

        public Boolean login(UsuarioModel usuarioModel)
        {
            string sql = "SELECT * FROM USUARIO WHERE EMAIL=@email and SENHA=@senha";

            SqlCommand cmd = new SqlCommand(sql, ConexaoBD.obterConexao());

           
            cmd.Parameters.AddWithValue("@email", usuarioModel.email);
            cmd.Parameters.AddWithValue("@senha", usuarioModel.senha);

            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

            ConexaoBD.fecharConexao();

        }
        

    }
}