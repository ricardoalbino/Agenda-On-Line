using Agenda_Online.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agenda_Online.Controller
{
    public class ContatoController
    {

        public void salvar(ContatoModel contatoModel)
        {
            contatoModel.salvar(contatoModel);
        }
    }
}