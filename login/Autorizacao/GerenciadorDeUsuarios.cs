using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autorizacao
{
    public class GerenciadorDeUsuarios
    {
        public Criterio[] criar(Usuario usuario)
        {
            return new Criterio[] { Criterio.Sucesso };
        }
    }
}