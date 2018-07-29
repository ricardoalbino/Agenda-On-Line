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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        protected void Button2_Click(object sender, EventArgs e)
        {

            

            string email = txtEmail.Text;
            string  senha = txtSenha.Text;

            if (email == "")
            {
                Response.Write("<script> alert('O campo Login deve ser preenchido!');</script>");
                txtEmail.Focus();
            }

            else if(senha == "")
            {
                Response.Write("<script> alert('O campo Senha deve ser preenchido!');</script>");
                txtSenha.Focus();
            }
            else
            {

                UsuarioModel usuarioModel = new UsuarioModel();

                usuarioModel.email = email;
                usuarioModel.senha = senha;

                UsuarioController usuarioController = new UsuarioController();


                if (usuarioController.login(usuarioModel))
                {
                    HttpCookie login = new HttpCookie("login", txtEmail.Text);
                    Response.Cookies.Add(login);

                    

                    Response.Redirect("index.aspx");

                }
                else
                {
                    Response.Write("<script> alert('Login ou senha está incorreto!!');</script>");
                   
                }

            }



        
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {


            Response.Redirect("Registrar.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            txtEmail.Text = "";
            txtSenha.Text = "";
        }
    }
}