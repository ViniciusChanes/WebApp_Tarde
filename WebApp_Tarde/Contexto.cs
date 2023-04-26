using Microsoft.EntityFrameworkCore;

namespace WebApp_Tarde
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto>opt):base(opt)
        {

        }

        public DbSet<ProdutoEntidade> Produtos { get; set;  }


    }
}
