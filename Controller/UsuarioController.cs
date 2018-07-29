using Agenda_Online.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agenda_Online.Controller
{
    public class UsuarioController
    {
        public void salvar(UsuarioModel usuarioModel)
        {

            usuarioModel.salvar(usuarioModel);

        }

        public Boolean login(UsuarioModel usuarioModel)
        {

            if (usuarioModel.login(usuarioModel))
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }

    }
}