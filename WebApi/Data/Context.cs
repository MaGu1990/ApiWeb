using ApiCadastro.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiCadastro.Data
{
    public class Context:DbContext 
    {
    public Context(DbContextOptions<Context> options ) 
        :base( options )
        { }

        public DbSet<Usuario> Usuarios { get; set; }    
         
    }
}
