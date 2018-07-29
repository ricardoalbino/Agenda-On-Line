using Agenda_Online.Controller;
using Agenda_Online.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agenda_Online.Views
{
    public partial class CadastroContato : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ContatoModel contatoModel = new ContatoModel();

            // CAPITURA OS DADOS DOS CAMPOS
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string tel = txtTel.Text;
            string cel = txtCel.Text;
            string rec = txtRec.Text;

            // VALIDA CAMPOS ANTES DE INSERIR UM NOVO REGISTRO
            if (nome == "")
            {
                Response.Write("<script> alert('O Campo nome está vazio!');</script>");
                txtNome.Focus();
            }

            else if (email == "")
            {
                Response.Write("<script> alert('O Campo email está vazio!');</script>");
                txtNome.Focus();
            }

            else if (tel == "")
            {
                Response.Write("<script> alert('O Campo telefone está vazio!');</script>");
                txtNome.Focus();
            }

            else if (cel == "")
            {
                Response.Write("<script> alert('O Campo celular está vazio!');</script>");
                txtNome.Focus();
            }


            else if (rec == "")
            {
                Response.Write("<script> alert('O Campo recado está vazio!');</script>");
                txtNome.Focus();
            }

            else
            {
                try
                {
                    // PASSA OS DADOS DO CAMPO PARA OS GETTES  E SETTERS
                    contatoModel.nome = nome;
                    contatoModel.email = email;
                    contatoModel.telefone = tel;
                    contatoModel.celular = cel;
                    contatoModel.recado = rec;

                    // ENVIA DADOS PARA CONTROLADOR, PARA ENVIAR PARA MODEL
                    ContatoController contatoController = new ContatoController();

                    contatoController.salvar(contatoModel);

                    Response.Redirect("contato.aspx");
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                    Response.Write("<script> alert('Erro!'+ ex.Message.ToString(););</script>");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            txtNome.Text = "";
            txtEmail.Text = "";
            txtTel.Text = "";
            txtCel.Text = "";
            txtRec.Text = "";

        }
    }
}