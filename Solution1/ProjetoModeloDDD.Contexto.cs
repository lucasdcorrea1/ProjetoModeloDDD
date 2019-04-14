using System;

namespace ProjetoModelo.Infra.Data.Contexto
{
    public class ProjetoModeloContxt : DbContext
    {
        public ProjetoModeloContxt()
            :base("ProjetoModeloDDD")
        {
            
        }

    }


}

