using Agenda_Online.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Agenda_Online.Models
{
    public class ContatoModel
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public string recado { get; set; }


        public void salvar(ContatoModel contatoModel)
        {
            string sql = "INSERT INTO CONTATO (nome, email, telefone, celular, recado) VALUES(@nome, @email, @telefone, @celular, @recado)";

            SqlCommand cmd = new SqlCommand(sql, ConexaoBD.obterConexao());

            cmd.Parameters.AddWithValue("@nome", contatoModel.nome);
            cmd.Parameters.AddWithValue("@email", contatoModel.email);
            cmd.Parameters.AddWithValue("@telefone", contatoModel.telefone);
            cmd.Parameters.AddWithValue("@celular", contatoModel.celular);
            cmd.Parameters.AddWithValue("@recado", contatoModel.recado);
            cmd.ExecuteNonQuery();

            ConexaoBD.fecharConexao();


        }
    }
}