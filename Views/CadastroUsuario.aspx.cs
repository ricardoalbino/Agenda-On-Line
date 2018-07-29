using Agenda_Online.Controller;
using Agenda_Online.Models;
using Agenda_Online.Util;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agenda_Online.Views
{
    public partial class CadastroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UsuarioModel usuario = new UsuarioModel();


            // CAPITURA OS DADOS DOS CAMPOS
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            // VALIDA CAMPOS ANTES DE INSERIR UM NOVO REGISTRO
            if (nome == "")
            {
                Response.Write("<script> alert('O campo Nome está vazio!');</script>");
            }
            else if (email == "")
            {
                Response.Write("<script> alert('O campo E-mail está vazio!');</script>");
            }
            else if (senha == "")
            {
                Response.Write("<script> alert('O campo Senha está vazio!');</script>");
            }
            else
            {

                try
                {
                    // PASSA OS DADOS DO CAMPO PARA OS GETTES  E SETTERS
                    usuario.nome = nome;
                    usuario.email = email;
                    usuario.senha = senha;

                    // ENVIA DADOS PARA CONTROLADOR, PARA ENVIAR PARA MODEL
                    UsuarioController usuarioController = new UsuarioController();
                    usuarioController.salvar(usuario);

                    Response.Redirect("usuario.aspx");
                }
                catch (Exception ex)
                {
                    Response.Write("<script> alert('Erro ao Cadastrar Usuario!');</script>");
                }
            }
  
        }
    }
}